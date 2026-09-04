using Microsoft.AspNetCore.Mvc;

namespace TeamGitPractice.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MembersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMembers()
    {
        var members = new[]
        {
            "Juan Sebastián Echeverri Gallego",
            "David Stiven Franco Lopez",
            "Marbel Juliana Mejía Bedoya",
            "Jhon Fernando Sánchez Álvarez",
            "Marlon García Sepúlveda"
        };
        return Ok(members);
    }

}
