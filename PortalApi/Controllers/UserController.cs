using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PortalApi.Entities;
using PortalApi.Helpers;
using PortalApi.Models;
using PortalApi.Services;

namespace PortalApi.Controllers
{

    [Authorize]
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public UsersController(
            IUserService userService,
            IMapper mapper,
            IOptions<AppSettings> appSettings)
        {
            _userService = userService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<ActionResult> Authenticate([FromBody] AuthenticateDto model)
        {
            var user = await _userService.Authenticate(model.Email, model.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            if (!user.EmailConfirmed)
                return BadRequest(new { message = "Please confirm you email first" });

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
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
                await _userService.Create(user, model.Password);

                string token = await _userService.SetEmailConfirmationToken(user.Id);
                var link = Url.Link("VerifyEmail",
                      new
                      {
                          userId = user.Id,
                          token
                      });

                Console.WriteLine(link);

                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [AllowAnonymous]
        [HttpGet("resendconfirmationemail/{userId}")]
        public async Task<ActionResult> ResendConfirmationEmail(int userId)
        {
            var user = await _userService.GetById(userId);
            if (user == null)
            {
                return BadRequest();
            }

            string token = await _userService.SetEmailConfirmationToken(user.Id);
            var link = Url.Link("VerifyEmail",
                  new
                  {
                      userId = user.Id,
                      token
                  });

            Console.WriteLine(link);

            return Ok();
        }

        [AllowAnonymous]
        [HttpPost("resetpassword")]
        public async Task<ActionResult> ResetPassword([FromBody]ResetPasswordDto model)
        {
            var user = await _userService.GetByEmail(model.Email);
            if (user == null)
            {
                return BadRequest();
            }

            string password = await _userService.ResetPassword(model.Email);
            Console.WriteLine(password);
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

            var user = await _userService.GetById(userId);

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

            await _userService.ConfirmEmail(userId, token);
            return Ok();
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
                await _userService.Update(user, model.Password);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _userService.Delete(id);
            return Ok();
        }
    }

}