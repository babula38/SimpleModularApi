using Microsoft.AspNetCore.Mvc;

namespace SImpleModular.Calculator.Add
{
    [Route("api/add")]
    public class AddController : ControllerBase
    {
        private readonly IMathService _mathService;

        public AddController(IMathService mathService)
        {
            _mathService = mathService;
        }

        [HttpPost]
        public IActionResult Post(int firstNumber, int secondNumber)
            => Ok(_mathService.Add(firstNumber, secondNumber));

        [HttpPost("record")]
        public IActionResult Post(AddRequest request)
        {
            var (firstNumber, secondNumber) = request;
            return Ok(_mathService.Add(firstNumber, secondNumber));
        }
    }

}

public record AddRequest(int FirstNumber, int SecondNumber);
