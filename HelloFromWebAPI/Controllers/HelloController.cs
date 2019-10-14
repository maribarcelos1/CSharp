using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloFromWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        // GET api/hello
        [HttpGet]
        public ActionResult<Object> Get()
        {
            return Ok(new {
                sucesso = true,
                nome = "",
                mensagem = $"Hello"
            });
        }

        // GET api/hello/pirelinho
        [HttpGet("{name}")]
        public ActionResult<Object> Get(string name)
        {
            return Ok(new {
                sucesso = true,
                nome = name,
                mensagem = $"Hello {name}"
            });
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
