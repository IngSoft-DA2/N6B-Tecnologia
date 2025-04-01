using Microsoft.AspNetCore.Mvc;

namespace predictions.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PilotosController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllPilotos()
    {
        return Ok("helloworld");
    }
}
