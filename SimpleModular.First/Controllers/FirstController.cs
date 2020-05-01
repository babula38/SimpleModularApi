
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class FirstController : ControllerBase
{
    [HttpGet]
    public string Get() => "From First module";

}