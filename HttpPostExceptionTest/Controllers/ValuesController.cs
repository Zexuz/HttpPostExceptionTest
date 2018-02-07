using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HttpPostExceptionTest.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Console.WriteLine("GET Index");
            throw new Exception();
        }

        // POST api/values
        [HttpPost]
        public void Post()
        {
            Console.WriteLine("POST Index");
            throw new Exception();
        }
    }
}