using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class AuthorsController : Controller
{
    private readonly ILogger<AuthorsController> _logger;

    public AuthorsController(ILogger<AuthorsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return Json(new { name = "Jose" });
    }
}
