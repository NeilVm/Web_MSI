#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web_MSI.Data;
using Web_MSI.Models;

namespace Web_MSI.Controllers
{
    public class ReporteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReporteController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Reporte()
        {
            return View(await _context.DataDiario.ToListAsync());
        }

       
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Reporte = await _context.DataDiario.FirstOrDefaultAsync(m => m.Id == id);
            if (Reporte == null)
            {
                return NotFound();
            }

            return View(Reporte);
        }

    }

        
        
    }