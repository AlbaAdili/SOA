using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Week_02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly ILogger<SampleController> _logger;

        public SampleController(ILogger<SampleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetGreetings()
        {
            return Ok("Hello All");
        }

        [HttpGet("/info/{name}/{surname}")]
        public IActionResult GreetSomeone(string name, string surname)
        {
            return Ok("Hello" + " " + name + " " + surname);
        }

        [HttpGet("/{age}")]
        public IActionResult GetAge(int age)
        {
            if (age >= 18)
            {
                return Ok("You are an adult");
            }
            return Ok("Nothing");
        }

        [HttpGet("today")]
        public IActionResult GetTodayDay()
        {
            string today = DateTime.Now.DayOfWeek.ToString();
            return Ok($"Today is {today}");
        }
    }
}
