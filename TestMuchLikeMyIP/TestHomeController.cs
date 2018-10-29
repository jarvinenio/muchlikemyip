using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestMuchLikeMyIP
{
    public class TestHomeController
    {

        [Fact]
        public void TestUserIp()
        {


            var mockContext = new Mock<HttpContext>();
            var mockRequest = new Mock<HttpRequest>();
            var mockConnection = new Mock<ConnectionInfo>();

            mockConnection.Setup(x => x.RemoteIpAddress).Returns(System.Net.IPAddress.Parse("127.0.0.1"));

            mockContext.Setup(x => x.Request).Returns(mockRequest.Object);
            mockContext.Setup(x => x.Connection).Returns(mockConnection.Object);



            var controller = new MuchLikeMyIP.Controllers.HomeController();
            controller.ControllerContext = new ControllerContext();
            controller.ControllerContext.HttpContext = mockContext.Object;

            var str = controller.UserIp().ToString();
            Assert.NotEmpty(str);
        }
    }
}
