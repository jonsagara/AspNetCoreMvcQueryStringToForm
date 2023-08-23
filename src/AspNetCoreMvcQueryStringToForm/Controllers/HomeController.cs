using System.Diagnostics;
using AspNetCoreMvcQueryStringToForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcQueryStringToForm.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(string? email)
    {
        // NOTE: Ignoring the bound query string parameter and explicitly setting the view model property to null.
        return View(new HomeIndexModel(Email: null));
    }
}
