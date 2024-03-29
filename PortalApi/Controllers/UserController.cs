﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Hangfire;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PortalApi.Entities;
using PortalApi.Helpers;
using PortalApi.Models;
using PortalApi.ProfilesProperties;
using PortalApi.Services;

namespace PortalApi.Controllers
{

    [Authorize]
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly AppSettings _appSettings;
        private readonly IMailService _mailService;
        private readonly ILogger<UsersController> _logger;

        public UsersController(
            IUserService userService,
            IMapper mapper,
            IOptions<AppSettings> appSettings,
            IMailService mailService,
            ILogger<UsersController> logger)
        {
            _userService = userService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
            _mailService = mailService;
            _logger = logger;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<ActionResult> Authenticate([FromBody] AuthenticateDto model)
        {
            var user = await _userService.AuthenticateAsync(model.Email, model.Password);

            if (user == null)
                return BadRequest(new { message = "Błędny email lub hasło" });

            if (!user.EmailConfirmed)
                return BadRequest(new { message = "Potwierdź swoje konto linkiem z mail'a" });

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            // return basic user info and authentication token
            return Ok(new
            {
                user.Id,
                user.Username,
                user.FirstName,
                user.LastName,
                Token = tokenString
            });
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] UserRegisterDto model)
        {
            // map model to entity
            var user = _mapper.Map<User>(model);

            try
            {
                // create user
                await _userService.CreateAsync(user, model.Password);

                string token = await _userService.SetEmailConfirmationTokenAsync(user.Id);
                var link = Url.Link("VerifyEmail",
                      new
                      {
                          userId = user.Id,
                          token
                      });

                BackgroundJob.Enqueue(() => _mailService.SendConfirmationEmail(user.Email, link, user.Username));
                return Ok();
            }
            catch (AppException ex)
            {
                _logger.LogError("There was an error while creating user: ", ex);
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [AllowAnonymous]
        [HttpPost("resendconfirmationemail")]
        public async Task<ActionResult> ResendConfirmationEmail([FromBody] ResendCofirmationEmailDto model)
        {
            var user = await _userService.GetByEmailAsync(model.Email);
            if (user == null)
            {
                return BadRequest();
            }

            if (user.EmailConfirmed)
            {
                return BadRequest();
            }

            string token = await _userService.SetEmailConfirmationTokenAsync(user.Id);
            var link = Url.Link("VerifyEmail",
                  new
                  {
                      userId = user.Id,
                      token
                  });

            BackgroundJob.Enqueue(() => _mailService.SendConfirmationEmail(user.Email, link, user.Username));
            return Ok();
        }

        [AllowAnonymous]
        [HttpPost("resetpassword")]
        public async Task<ActionResult> ResetPassword([FromBody]ResetPasswordDto model)
        {
            var user = await _userService.GetByEmailAsync(model.Email);
            if (user == null)
            {
                return BadRequest();
            }

            string password = await _userService.ResetPasswordAsync(user);

            BackgroundJob.Enqueue(() => _mailService.SendPasswordResetEmail(user.Email, password, user.Username));
            return Ok();
        }

        [AllowAnonymous]
        [HttpGet("confirm", Name = "VerifyEmail")]
        public async Task<IActionResult> VerifyEmail(int userId, string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest();
            }

            var user = await _userService.GetByIdAsync(userId);

            if (user == null)
            {
                return BadRequest();
            }

            if (user.EmailConfirmationToken != token)
            {
                return Unauthorized("Invalid token");
            }

            if (user.EmailConfirmed)
            {
                return Ok();
            }

            await _userService.ConfirmEmailAsync(userId, token);
            return Ok();
        }

        [HttpPost("seruserbasicinfo")]
        public async Task<ActionResult> SetUserBasicInfo([FromBody]UserBasicInfoDto model)
        {
            var currentUserID = int.Parse(User.Identity.Name);

            if (!Enum.IsDefined(typeof(Gender), model.Gender))
            {
                ModelState.AddModelError(
                    "Gender",
                    "This gender does not exist");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            User user = await _userService.GetByIdAsync(currentUserID);
            _mapper.Map(model, user);

            await _userService.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] UserUpdateDto model)
        {
            // map model to entity and set id
            var user = _mapper.Map<User>(model);
            user.Id = id;

            try
            {
                // update user 
                await _userService.UpdateAsync(user, model.Password);
                return Ok();
            }
            catch (AppException ex)
            {
                _logger.LogError("There was an error while updating user: ", ex);
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _userService.DeleteAsync(id);
            return Ok();
        }
    }

}