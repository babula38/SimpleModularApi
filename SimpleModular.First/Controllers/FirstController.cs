using Microsoft.AspNetCore.Mvc;

namespace SimpleModular.First.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirstController : ControllerBase
    {
        private readonly MessageService _service;
        public FirstController(MessageService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_service.Message());

    }
}