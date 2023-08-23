using AspNetCoreMvcQueryStringToForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcQueryStringToForm.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(string? email)
    {
        // NOTE: Ignore the bound query string parameter and explicitly set the model property to null.
        return View(new HomeIndexModel(Email: null));
    }

    public IActionResult Workaround(string? email)
    {
        // This removes "email" from ModelState, preventing asp-for from populating the form field.
        ModelState.Remove(nameof(email));

        // NOTE: Ignore the bound query string parameter and explicitly set the model property to null.
        return View(new HomeWorkaroundModel(Email: null));
    }
}
