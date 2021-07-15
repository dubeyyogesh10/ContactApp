using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactAppController : ControllerBase
    {
        // GET: api/<ContactAppController>
        [HttpGet]
        public IEnumerable<string> GetContacts()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ContactAppController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ContactAppController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ContactAppController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContactAppController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
