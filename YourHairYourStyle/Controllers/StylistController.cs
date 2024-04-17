using Microsoft.AspNetCore.Mvc;
using YourHairYourStyle.Persistence;

namespace YourHairYourStyle.Controllers
{
    public class StylistController : Controller
    {
        private readonly DataContext _context;

        public StylistController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
