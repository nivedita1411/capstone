using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jwtapi.Models;
using jwtapi.Controllers;
using System.Text;
using System.Text.RegularExpressions;
using System.IdentityModel.Tokents.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace jwtapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class usercontroller : ControllerBase
    {
        private readonly AppdbContext _authContext;
        public usercontroller(AppdbContext context)
        {
            _authContext = context;
        }
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] user userObj)
        {
            if(userObj == null) return BadRequest();
            var user = await _authContext.Users.FirstOrDefaultAsync(x = x.Username
            ==userObj.Username);
            if(user == null)
            {
                return DllNotFoundException(new {Message = "User Not Found"});
            }
        }
    }
}