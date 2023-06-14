using Microsoft.AspNetCore.Mvc;

namespace _safeprojectname_.Calculator.Substract
{
    [Route("api/substract")]
    public class SubstractController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(int firstNumber, int secondNumber) => Ok(firstNumber - secondNumber);

        [HttpPost("record")]
        public IActionResult Post(AddRequest request) => Ok(request.FirstNumber - request.SecondNumber);

    }

}

public record AddRequest(int FirstNumber, int SecondNumber);
