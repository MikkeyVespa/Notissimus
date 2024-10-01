using Microsoft.AspNetCore.Mvc;
using Notiss.Models;
using System;
using System.Diagnostics;

namespace Notiss.Controllers
{

    public class HomeController : Controller
    {
        private readonly DbContextNotiss _context;

        public HomeController(DbContextNotiss context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveCoordinates([FromBody] Coordinate mouseCoordinate)
        {
            if (mouseCoordinate == null)
            {
                return BadRequest();
            }

            _context.Coordinates.Add(mouseCoordinate);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
