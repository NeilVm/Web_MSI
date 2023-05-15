using System.Diagnostics;
using Web_MSI.Models;
using Microsoft.AspNetCore.Identity;
namespace Web_MSI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Web_MSI.Data;
public class UsersController : Controller
{
  
private readonly UserManager<ApplicationUser> _userManager;
private readonly ApplicationDbContext _context;
public UsersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

public async Task<IActionResult> GetEmail(string userId)
{
    var user = await _userManager.FindByIdAsync(userId);
    if (user != null)
    {
        string email = user.Email;
    
        return Ok(email);
    }
    else
    {
        
        return View();
    }

}
    public IActionResult Users()
    {
        var emails = _context.Users.Select(u => u.Email).ToList();
        List<ApplicationUser> users = _context.Users.ToList();
        return View(users);
    }

}