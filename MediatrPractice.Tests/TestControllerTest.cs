using MediatrPractice.Controllers;
using MediatrPractice.Services;
using Microsoft.AspNetCore.Mvc;

namespace MediatrPractice.Tests
{
    public class TestControllerTest
    {
        private readonly TestController _controller;
        private readonly ITestService _service;

        public TestControllerTest()
        {
            _service = new TestServiceFake();
            _controller = new TestController(_service);
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