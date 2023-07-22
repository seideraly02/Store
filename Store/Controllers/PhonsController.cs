using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Store.Models;
using Store.ViewModels;

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
            CreatePhoneViewModel viewModel = new CreatePhoneViewModel()
            {
                Brands = db.Brands.ToList(),
                Phone = new Phone()
            };
                
            return View(viewModel);
        }
        
        [HttpPost]
        public IActionResult Create(CreatePhoneViewModel model)
        {
            if (model != null)
            {
                db.Phones.Add(model.Phone);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            CreatePhoneViewModel viewModel = new CreatePhoneViewModel()
            {
                Brands = db.Brands.ToList(),
                Phone =  db.Phones.FirstOrDefault(p => p.Id == id)
            };
            return View(viewModel);
            /*Phone phone =;
            if (phone != null)
            {
                return View(phone);
            }*/

            return NotFound();
        }
        
        [HttpPost]
        public IActionResult Edit(CreatePhoneViewModel model)
        {
            if (model.Phone != null)
            {
                db.Phones.Update(model.Phone);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                Phone phone = db.Phones.FirstOrDefault();
                if (phone != null)
                {
                    return View(phone);
                }
            }
            return NotFound();
        } 
        
        
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Phone phone = db.Phones.FirstOrDefault();
                if (phone != null)
                {
                    db.Phones.Remove(phone);
                    db.SaveChanges();
                }
            }
            return RedirectToAction();
        } 
    } 
}