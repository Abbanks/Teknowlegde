using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Teknowlegde.Data;
using Teknowlegde.Models;

namespace Teknowlegde.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var allStudents = _context.Students.ToList();

            var student = allStudents.Select(s => new StudentViewModel()
            {
                Name = s.Name
            }).ToList();
            return View(student);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
