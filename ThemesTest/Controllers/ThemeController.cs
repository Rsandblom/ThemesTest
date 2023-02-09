using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ThemesTest.Controllers;

[Route("/[controller]")]
[ApiController]
public class ThemeController : ControllerBase
{
    [HttpGet("change")]
    public async Task<ActionResult> ChangeTheme([FromQuery] string theme)
    {
        Response.Cookies.Append("theme", theme);
        return Redirect("/");
    }
}
