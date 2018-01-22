using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cryptonians_api.Controllers
{
    [Route("api/test")]
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            string moo = "hello peeps";
            return Ok(moo);
        }

       
    }
}
