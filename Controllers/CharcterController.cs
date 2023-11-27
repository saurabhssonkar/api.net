using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.net.model;


using Microsoft.AspNetCore.Mvc;

namespace api.net.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharcterController :ControllerBase
    {

        

        private static List<Character> characters =new List<Character>(){
            
            new Character(),
            new Character {Name = "Sam"}
        };
        

        [HttpGet]

        public ActionResult<List<Character>> Get(){
             Console.WriteLine("Line was@@@@@@@@@@@@@ ");
            return Ok(characters);
        }
        
    }
}