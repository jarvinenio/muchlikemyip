using System;
using Xunit;
using MuchLikeMyIP;

namespace TestMuchLikeMyIP
{
    public class TestParteryController
    {
        [Fact]
        public void TestGetPastes()
        {
            var pasteryController = new MuchLikeMyIP.Controllers.PasteryController();

            Assert.NotEmpty(pasteryController.GetPastes());
        }
    }
}
