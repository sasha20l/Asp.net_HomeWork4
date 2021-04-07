using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetricsAgent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetricAgentController : ControllerBase
    {
        [HttpPost("read")]
        public IActionResult GetFullMetric()
        {
            return Ok();
        }
        [HttpPut("enable")]
        public IActionResult EnableAgentById()
        {
            return Ok();
        }
        [HttpPut("disable")]
        public IActionResult DisableAgentById()
        {
            return Ok();
        }
    }
}

