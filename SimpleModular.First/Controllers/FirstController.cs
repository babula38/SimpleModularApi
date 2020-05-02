using Microsoft.AspNetCore.Mvc;
using SimpleModular.First.Modules;
using SimpleModular.First.Services;

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
        public IActionResult Get() => Ok(new FirstResponse() { Message = _service.Message() });

    }
}