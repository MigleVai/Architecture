using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Architecture.Models;
using Microsoft.AspNetCore.Mvc;

namespace Architecture.Controllers
{
    public class SaleController : Controller
    {
        public IActionResult Index()
        {
            return View(Storage.SaleList);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SaleModel sale)
        {
            sale.Id = Guid.NewGuid();
            Storage.SaleList.Add(sale);
            return RedirectToAction("Index", "Sale");
        }

        public IActionResult Edit(Guid id)
        {
            var sale = Storage.SaleList.FirstOrDefault(a => a.Id == id);
            return View(sale);
        }

        [HttpPost]
        public IActionResult Edit(SaleModel sale)
        {
            Storage.SaleList.RemoveAll(a => a.Id == sale.Id);
            Storage.SaleList.Add(sale);
            return RedirectToAction("Index", "Sale");
        }

        public IActionResult Delete(Guid id) {
            var sale = Storage.SaleList.FirstOrDefault(a => a.Id == id);
            return View(sale);
        }

        [HttpPost]
        public IActionResult Delete(SaleModel sale) {
            Storage.SaleList.RemoveAll(a => a.Id == sale.Id);
            return RedirectToAction("Index", "Sale");
        }
    }
}