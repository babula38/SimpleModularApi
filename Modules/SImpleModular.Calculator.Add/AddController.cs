using Microsoft.AspNetCore.Mvc;

namespace SImpleModular.Calculator.Add
{
    [Route("api/add")]
    public class AddController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(int firstNumber, int secondNumber) => Ok(firstNumber + secondNumber);

        [HttpPost("record")]
        public IActionResult Post(AddRequest request)
        {
            var (firstNumber, secondNumber) = request;
            return Ok(firstNumber + secondNumber);
        }
    }

}

public record AddRequest(int FirstNumber, int SecondNumber);
