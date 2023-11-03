using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace demowebapp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FruitsController : ControllerBase
    {
        static List<string> Fruits = new List<string> {"Apple","Mango","Orange","Grapes","Banana"};
        [HttpGet]
        // public IEnumerable<string> Get()
        // {
        //     return Fruits;
        // }
        [Route("ShowFruits")]
        public IEnumerable<string> GetFruits()
        {
            return Fruits;
        }
        [HttpGet("{id}")]
        public string GetFruits(int id)
        {
            return Fruits[id];
        }
    }
}