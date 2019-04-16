using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSApiSample.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMediator mediator;

        public ValuesController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            var result = await mediator.Send(new CityRequest(id));
            return result.Name;
        }

        [HttpGet("List")]
        public async Task<ActionResult<IEnumerable<CityDTO>>> GetList(string name)
        {
            var result = await mediator.Send(new CityListRequest { Name = name  });
            return result.ToList();
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
