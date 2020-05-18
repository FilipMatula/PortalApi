﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Okta.Sdk;
using Okta.Sdk.Configuration;
using PortalApi.Models;

namespace PortalApi.Controllers
{

    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public UsersController(IConfiguration configuration)
        {
            _configuration = configuration ??
                throw new ArgumentNullException(nameof(configuration));
        }

        [HttpPost]
        public async void Post([FromBody]Registration reg)
        {
            var oktaClient = new OktaClient(new OktaClientConfiguration
            {
                OktaDomain = _configuration["oktaSettings:OktaDomain"],
                Token = _configuration["oktaSettings:Token"]
            });
            var user = await oktaClient.Users.CreateUserAsync(
             new CreateUserWithPasswordOptions
             {
                 Profile = new UserProfile
                 {
                     FirstName = reg.FirstName,
                     LastName = reg.LastName,
                     Email = reg.Email,
                     Login = reg.Email
                 },
                 Password = reg.Password,
                 Activate = true
             }
         );
        }
    }

}