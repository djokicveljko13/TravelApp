using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using TravelApp.Domain.Entities;
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
            var villas = applicationDbContext.Villas.ToList();
            return View(villas);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Villa villa)
        {
            if (villa.Name == villa.Description)
            {
                ModelState.AddModelError("name", "The description cannot be the same as the name.");
            }
            if (ModelState.IsValid) //server side validation
            {
                applicationDbContext.Villas.Add(villa);
                applicationDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
