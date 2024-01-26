using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{oper}/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string oper, string firstNumber, string secondNumber)
        {

            return BadRequest("Invalid Input");
        }
    }
}
