using System;
using Architecture.Domain;
using Architecture.Domain.Storage;
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