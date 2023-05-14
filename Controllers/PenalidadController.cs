using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_MSI.Models;

namespace Web_MSI.Controllers;

public class PenalidadController : Controller
{
    private readonly ILogger<PenalidadController> _logger;

    public PenalidadController(ILogger<PenalidadController> logger)
    {
        _logger = logger;
    }

    public IActionResult penalidad()
    {
        return View();
    }
}