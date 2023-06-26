using JucarAutopartesAplicacionWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace JucarAutopartesAplicacionWeb.Controllers.Products
{
    public class AutopartsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AutopartsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
