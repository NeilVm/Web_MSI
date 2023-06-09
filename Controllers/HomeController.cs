﻿#nullable disable
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
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> inicio()
        {
            return View(await _context.DataPenalidades.ToListAsync());
        }

        // GET: Producto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var penalidades = await _context.DataPenalidades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (penalidades == null)
            {
                return NotFound();
            }

            return View(penalidades);
        }

    }

        
        
    }