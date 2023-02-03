using MediatrPractice.Domain.Entities.Movies;
using MediatrPractice.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatrPractice.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestService _service;
        public TestController(ITestService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var items = _service.GetAllItems();
            return Ok(items);
        }
        [HttpGet("{id}")]
        public IActionResult Get(string title)
        {
            var item = _service.GetByTitle(title);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Movie value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var item = _service.Add(value);
            return CreatedAtAction("Get", new { title = value.Title }, item);
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(string title)
        {
            var existingItem = _service.GetByTitle(title);
            if (existingItem == null)
            {
                return NotFound();
            }
            _service.Remove(title);
            return NoContent();
        }
    }
}
