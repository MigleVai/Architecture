using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Architecture.Domain;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Architecture.Controllers
{
    public class SaleController : Controller
    {
        private const string URL = "http://localhost:8080";
        public async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL);
                var response = await client.GetAsync($"/api/saleBackend");
                var result = JsonConvert.DeserializeObject<List<SaleModel>>(await response.Content.ReadAsStringAsync());

                return View(result);
            }
        }
        public IActionResult Create()
        {
            return View(new SaleModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaleModel sale)
        {
            if (ModelState.IsValid)
            {
                sale.Id = Guid.NewGuid();
                var content = new StringContent(JsonConvert.SerializeObject(sale), Encoding.UTF8, "application/json");
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(URL);
                    var response = await client.PostAsync($"/api/saleBackend", content);
                    return RedirectToAction("Index", "Sale");
                }
            }
            return View();
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL);
                var response = await client.GetAsync($"/api/saleBackend/{id.ToString()}");
                var result = JsonConvert.DeserializeObject<SaleModel>(await response.Content.ReadAsStringAsync());
                return View(result);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SaleModel sale)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(URL);
                    var content = new StringContent(JsonConvert.SerializeObject(sale), Encoding.UTF8, "application/json");
                    var response = await client.PutAsync($"/api/saleBackend/{sale.Id.ToString()}", content);
                    return RedirectToAction("Index", "Sale");
                }
            }
            return View();
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL);
                var sale = await client.GetAsync($"/api/saleBackend/{id.ToString()}");
                var result = JsonConvert.DeserializeObject<SaleModel>(await sale.Content.ReadAsStringAsync());
                return View(result);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(SaleModel sale)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL);
                await client.DeleteAsync($"/api/saleBackend/{sale.Id.ToString()}");
                return RedirectToAction("Index", "Sale");
            }
        }
    }
}