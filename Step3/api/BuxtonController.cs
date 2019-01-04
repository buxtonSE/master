using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Step3.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuxtonController : ControllerBase
    {
        public BuxtonController()
        {

        }

        [HttpGet]
        [Route("foobar/{test}")]
        public int foobar(string test)
        {
            return test.Count();
        }
    }
}