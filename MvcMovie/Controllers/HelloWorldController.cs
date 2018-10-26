using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Text.Encodings.Web;
using ControllerDI.Interfaces;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //Dependency injection example
        private readonly IDateTime _dateTime;

        public HelloWorldController(IDateTime dateTime)
        {
            _dateTime = dateTime;
        }



        // GET: /HelloWorld/
        public string Index()
        {
            return "Hello world!";
        }



        // GET: /HelloWorld/Welcome/ 
       public string Welcome(string name, int ID = 0)
        {
            if (name == null || name == string.Empty || ID == 0) {
                return "This is the Welcome action method...";
            } else {
                return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
            }
        }

        //Attributes, demo both direct-mapped route and HTTP verbs
        [HttpGet("/TestGet")]
        public string GetOnly() { 
            return "Only show for GET!";
        }

        [HttpPost("/TestPost")]
        public string PostOnly() { 
            return "Only show for POST!";
        }

        public IActionResult Advanced(string name, int ID = 0, int numTimes  = 1)
        {
            ViewData["Message"] = HtmlEncoder.Default.Encode($"Hello {name}, your ID is {ID}!");
            ViewData["ID"] = ID;            
            ViewData["NumTimes"] = numTimes;
            //Dependency injection example
            ViewData["CurrentTime"] = _dateTime.Now;
            //Url Generator example
            ViewData["CurrentUrl"] = Url.Action("Welcome2", new {id = ID,name = name, numTimes = numTimes});
            ViewData["CurrentUrlAbs"] = Url.Action("Welcome2", "HelloWord", new {id = ID,name = name, numTimes = numTimes}, protocol: Request.Scheme);
            return View();
        }
    }


    //Token and inheritance example
    [Route("API/[controller]")]
    public abstract class ApiBaseController : Controller { 
        public readonly string BaseString = "test base string";
    }

    public class HelloWorldApiController : ApiBaseController
    {
        [HttpGet] // Matches '/API/HelloWorldApi/'
        public string Test() { 
            return "This is the base class string: " + BaseString;
        }
    }

}
