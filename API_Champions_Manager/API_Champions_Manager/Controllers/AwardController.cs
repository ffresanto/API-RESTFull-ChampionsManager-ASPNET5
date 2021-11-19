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
    [Route("[api/controller]")]
    public class AwardController : ControllerBase
    {
        private readonly ILogger<AwardController> _logger;
        private IAwardService _awardService;

        public AwardController(ILogger<AwardController> logger, IAwardService awardService)
        {
            _logger = logger;
            _awardService = awardService;
        }
    }
}
