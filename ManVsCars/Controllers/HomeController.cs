using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManVsCars.Controllers
{
    [Route("{action = Index}")]
    public class HomeController : Controller
    {
        // GET: Home
        [Route("")]
        public string Index()
        {
            return "'Sup World!";
        }

        [Route("Hello/stuff/{stuff?}")]
        [HttpGet]
        public string Get(string stuff)
        {
            if(String.IsNullOrEmpty(stuff))
            {
                return "Hello, hello";
            }
            return stuff;
        }

        [Route("Hello/{incantation:magicWords}")]
        public string OpenSesesime(string incantation)
        {
            return "You said one of the magic words: " + incantation;
        }
    }
}