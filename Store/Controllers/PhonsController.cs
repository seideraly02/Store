using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Store.Models;

namespace Store.Controllers
{
    public class PhonesController : Controller
    {
        private StoreContext db;

        public PhonesController(StoreContext _db)
        {
            db = _db;
        }
        
        // GET
        public IActionResult Index()
        {
            List<Phone> phones = db.Phones.ToList();
            return View(phones);
        }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Phone phone)
        {
            if (phone != null)
            {
                db.Phones.Add(phone);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    } 
}