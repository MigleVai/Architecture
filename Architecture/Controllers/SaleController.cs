using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Architecture.Models;
using Architecture.Storage;
using Microsoft.AspNetCore.Mvc;

namespace Architecture.Controllers
{
    public class SaleController : Controller
    {
        private IStorage _storage;

        public SaleController(IStorage storage)
        {
            _storage = storage;
        }
        public IActionResult Index()
        {
            return View(_storage.GetAll());
        }
        public IActionResult Create()
        {
            return View(new SaleModel());
        }

        [HttpPost]
        public IActionResult Create(SaleModel sale)
        {
            if (ModelState.IsValid)
            {
                if (sale.StartSale < DateTime.Now && sale.EndSale < DateTime.Now)
                {
                    ModelState.AddModelError(string.Empty, "The start and end dates have to be greater than today.");
                    return View(sale);
                }
                if (sale.StartSale + TimeSpan.FromDays(14) <= sale.EndSale)
                {
                    ModelState.AddModelError(string.Empty, "The sale duration must not be more than 2 weeks.");
                    return View(sale);
                }
                sale.Id = Guid.NewGuid();
                _storage.Add(sale);
                return RedirectToAction("Index", "Sale");
            }
            return View();
        }

        public IActionResult Edit(Guid id)
        {
            var sale = _storage.Get(id);
            return View(sale);
        }

        [HttpPost]
        public IActionResult Edit(SaleModel sale)
        {
            if (ModelState.IsValid)
            {
                if (sale.StartSale < DateTime.Now && sale.EndSale < DateTime.Now)
                {
                    ModelState.AddModelError(string.Empty, "The start and end dates have to be greater than today.");
                    return View(sale);
                }
                if (sale.StartSale + TimeSpan.FromDays(14) <= sale.EndSale)
                {
                    ModelState.AddModelError(string.Empty, "The sale duration must not be more than 2 weeks.");
                    return View(sale);
                }
                _storage.Remove(sale.Id);
                _storage.Add(sale);
                return RedirectToAction("Index", "Sale");
            }
            return View();
        }

        public IActionResult Delete(Guid id)
        {
            var sale = _storage.Get(id);
            return View(sale);
        }

        [HttpPost]
        public IActionResult Delete(SaleModel sale)
        {
            _storage.Remove(sale.Id);
            return RedirectToAction("Index", "Sale");
        }
    }
}