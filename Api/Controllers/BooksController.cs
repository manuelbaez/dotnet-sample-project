using BusinessLogic.Dtos;
using BusinessLogic.Services.Configuration;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/books")]
public class BooksController : Controller
{
    private readonly ILogger<BooksController> _logger;
    private readonly IService<BookDto> service;

    public BooksController(ILogger<BooksController> logger, IService<BookDto> service)
    {
        _logger = logger;
        this.service = service;
    }

    [HttpGet()]
    public IActionResult Get()
    {
        return Json(service.GetAll());
    }
}
