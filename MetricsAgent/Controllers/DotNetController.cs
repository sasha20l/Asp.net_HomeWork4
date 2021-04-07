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
    public class DotNetController : ControllerBase
    {
        [HttpGet("api/metrics/dotnet/errors-count/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsDotNet([FromRoute] TimeSpan fromTime,
        [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
