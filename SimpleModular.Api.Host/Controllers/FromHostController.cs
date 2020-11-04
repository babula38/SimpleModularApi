
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class FromHostController : ControllerBase
{
    [HttpGet]
    public string Get() => "From api host";
}