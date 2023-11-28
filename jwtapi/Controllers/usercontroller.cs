using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jwtapi.Models;
using jwtapi.Controllers;

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
    }
}