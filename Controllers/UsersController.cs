using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_MSI.Models;

namespace Web_MSI.Controllers;

public class UsersController : Controller
{
    private readonly ILogger<PenalidadController> _logger;

    public UsersController(ILogger<PenalidadController> logger)
    {
        _logger = logger;
    }

    public IActionResult users()
    {
        return View();
    }
}