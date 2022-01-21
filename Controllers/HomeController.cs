using Eterna.Models;
using Eterna.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    { 
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

           
            HomeVM model = new HomeVM
            {
                Sliders = _context.Sliders.ToList(),
                Features = _context.Features.ToList(),
                Clients = _context.Clients.ToList(),
            };
            return View(model);
        }
    }
}
