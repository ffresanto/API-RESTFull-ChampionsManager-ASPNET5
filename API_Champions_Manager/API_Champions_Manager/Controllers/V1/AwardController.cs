using API_Champions_Manager.Business;
using API_Champions_Manager.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API_Champions_Manager.Controllers.V1
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class AwardController : ControllerBase
    {
        private readonly ILogger<AwardController> _logger;
        private IAwardBusiness _awardBusiness;

        public AwardController(ILogger<AwardController> logger, IAwardBusiness awardBusiness)
        {
            _logger = logger;
            _awardBusiness = awardBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_awardBusiness.FindAll());
        }

        // Maps GET requests to https://localhost:{port}/api/person/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _awardBusiness.FindById(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        // Maps POST requests to https://localhost:{port}/api/person/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPost]
        public IActionResult Post([FromBody] Award award)
        {
            if (award == null) return BadRequest();
            return Ok(_awardBusiness.Create(award));
        }

        // Maps PUT requests to https://localhost:{port}/api/person/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPut]
        public IActionResult Put([FromBody] Award award)
        {
            if (award == null) return BadRequest();
            return Ok(_awardBusiness.Update(award));
        }

        // Maps DELETE requests to https://localhost:{port}/api/person/{id}
        // receiving an ID as in the Request Path
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _awardBusiness.Delete(id);
            return NoContent();
        }
    }
}
