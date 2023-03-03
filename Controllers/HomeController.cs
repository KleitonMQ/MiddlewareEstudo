using Microsoft.AspNetCore.Mvc;

namespace MiddlewareEstudo.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet("/")]
    public IActionResult Index()
    {
        return Ok(new { Message = "Hello from ASP.NET Core!", Header = HttpContext.Response.Headers["X-Custom-Header"] });
    }
}
