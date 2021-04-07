using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetricsAgent.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetricsAgent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CpuController : ControllerBase
    {
       

        [HttpGet("api/metrics/cpu//from/{fromTime}/to/{toTime}/")]
        public IActionResult GetMetricsCpu([FromRoute] TimeSpan fromTime,
        [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
        [HttpGet("api/metrics/cpu/from/{fromTime}/to/{toTime}/percentiles/{percentile}")]
        public IActionResult GetMetricsByPercentileCpu([FromRoute]
        TimeSpan fromTime, [FromRoute] TimeSpan toTime, [FromRoute] Percentile percentile)
        {
            return Ok();
        }
    }
}
namespace MetricsAgent.Enums
{
    public enum Percentile
    {
        Median = 0,
        P75 = 1,
        P90 = 2,
        P95 = 3,
        P99 = 4
    }
}
