using Asp.net_2.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerTest
{
    public class UnitTest1
    {
        public class CpuControllerUnitTests
        {
            private CpuMetricsController controller;

            public CpuControllerUnitTests()
            {
                controller = new CpuMetricsController();
            }

            [Fact]
            public void GetMetricsFromAgent_ReturnsOk()
            {
                //Arrange
                var agentId = 1;
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);

                //Act
                var result = controller.GetMetricsFromAgent(agentId, fromTime, toTime);

                // Assert
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
        }

    }
}
