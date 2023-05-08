using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_MSI.Models;

namespace Web_MSI.Controllers;

public class RolesController : Controller
{
    private readonly ILogger<RolesController> _logger;

    public RolesController(ILogger<RolesController> logger)
    {
        _logger = logger;
    }

    public IActionResult roles()
    {
        return View();
    }
}