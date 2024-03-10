using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using AuthExample2.Models;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
namespace AuthExample2.Controllers

{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController: Controller
    {
        AuthExampleContext authExampleContext = new AuthExampleContext();

        [Route("get/{login}")]
        public IActionResult GetLogin([FromRoute]string login)
        {
            var user = authExampleContext.Users.FirstOrDefault(user => user.Login == login);
            return Ok(user);
        }

    }
}
