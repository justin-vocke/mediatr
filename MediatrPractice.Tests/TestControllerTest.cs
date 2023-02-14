using MediatrPractice.Controllers;
using MediatrPractice.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace MediatrPractice.Tests
{
    public class TestControllerTest
    {
        private readonly TestController _controller;
        private readonly Mock<ITestService> _mockService;

        public TestControllerTest()
        {
            _mockService = new Mock<ITestService>();
            _controller = new TestController(_mockService.Object);
        }

        [Test]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            //Act
            var okResult = _controller.Get();
            Assert.IsInstanceOf<OkObjectResult>(okResult as OkObjectResult);
        }
    }
}