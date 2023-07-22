using Microsoft.AspNetCore.Mvc;
using Store.Models;

namespace Store.Controllers
{
    public class BrandsController : Controller
    {
        private StoreContext _db;

        public BrandsController(StoreContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        // GET
        
        [HttpPost]
        public IActionResult Create(Brand brand)
        {
            _db.Brands.Add(brand);
            _db.SaveChanges();
            return View();
        }
    }
}