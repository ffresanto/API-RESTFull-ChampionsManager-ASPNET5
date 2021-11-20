using API_Champions_Manager.Model;
using API_Champions_Manager.Services;
using API_Champions_Manager.Services.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Champions_Manager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AwardController : ControllerBase
    {
        private readonly ILogger<AwardController> _logger;
        private IAwardService _awardService;

        public AwardController(ILogger<AwardController> logger, IAwardService awardService)
        {
            _logger = logger;
            _awardService = awardService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_awardService.FindAll());
        }

        // Maps GET requests to https://localhost:{port}/api/person/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _awardService.FindById(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        // Maps POST requests to https://localhost:{port}/api/person/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPost]
        public IActionResult Post([FromBody] Award award)
        {
            if (award == null) return BadRequest();
            return Ok(_awardService.Create(award));
        }

        // Maps PUT requests to https://localhost:{port}/api/person/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPut]
        public IActionResult Put([FromBody] Award award)
        {
            if (award == null) return BadRequest();
            return Ok(_awardService.Update(award));
        }

        // Maps DELETE requests to https://localhost:{port}/api/person/{id}
        // receiving an ID as in the Request Path
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _awardService.Delete(id);
            return NoContent();
        }
    }
}
