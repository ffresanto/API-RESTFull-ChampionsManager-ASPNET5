using API_Champions_Manager.Business;
using API_Champions_Manager.Data.VO;
using API_Champions_Manager.HyperMedia.Filters;
using API_Champions_Manager.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

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
        [ProducesResponseType((200), Type = typeof(List<AwardVO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_awardBusiness.FindAll());
        }

        // Maps GET requests to https://localhost:{port}/api/award/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(AwardVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var award = _awardBusiness.FindById(id);
            if (award == null) return NotFound();
            return Ok(award);
        }

        // Maps POST requests to https://localhost:{port}/api/award/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPost]
        [ProducesResponseType((200), Type = typeof(AwardVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] AwardVO award)
        {
            if (award == null) return BadRequest();
            return Ok(_awardBusiness.Create(award));
        }

        // Maps PUT requests to https://localhost:{port}/api/award/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPut]
        [ProducesResponseType((200), Type = typeof(AwardVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] AwardVO award)
        {
            if (award == null) return BadRequest();
            return Ok(_awardBusiness.Update(award));
        }

        // Maps DELETE requests to https://localhost:{port}/api/award/{id}
        // receiving an ID as in the Request Path
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Delete(long id)
        {
            _awardBusiness.Delete(id);
            return NoContent();
        }
    }
}
