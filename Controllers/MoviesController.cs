﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using new_testapp.Data;
using System.Linq;
using System.Threading.Tasks;

namespace new_testapp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.Include(n=>n.Cinema).OrderBy(n=>n.Name).ToListAsync();
            return View(allMovies);
        }
    }
}
