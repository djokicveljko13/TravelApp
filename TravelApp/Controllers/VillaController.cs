using Microsoft.AspNetCore.Mvc;
using TravelApp.Infrastructure.Data;

namespace TravelApp.Controllers
{
    public class VillaController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public VillaController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            var villas= applicationDbContext.Villas.ToList();
            return View(villas);
        }
    }
}
