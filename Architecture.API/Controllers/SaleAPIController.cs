using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Architecture.Domain;
using Architecture.Domain.Storage;

namespace Architecture.API.Controllers
{
    [Route("api/saleBackend")]
    [ApiController]
    public class SaleAPIController : ControllerBase
    {
        private IStorage<SaleModel> _storage;

        public SaleAPIController(IStorage<SaleModel> storage)
        {
            _storage = storage;
        }

        // GET: api/Sale
        [HttpGet]
        public IEnumerable<SaleModel> GetSaleModel()
        {
            return _storage.GetAll();
        }

        // GET: api/SaleAPI/5
        [HttpGet("{id}")]
        public IActionResult GetSaleModel([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var saleModel = _storage.Get(id);

            if (saleModel == null)
            {
                return NotFound();
            }

            return Ok(saleModel);
        }

        // PUT: api/SaleAPI/5
        [HttpPut("{id}")]
        public IActionResult PutSaleModel([FromRoute] Guid id, [FromBody] SaleModel saleModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != saleModel.Id)
            {
                return BadRequest();
            }

            _storage.Remove(id);
            _storage.Add(saleModel);
            _storage.Save();

            return NoContent();
        }

        // POST: api/SaleAPI
        [HttpPost]
        public IActionResult PostSaleModel([FromBody] SaleModel saleModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            saleModel.Id = Guid.NewGuid();
            _storage.Add(saleModel);
            _storage.Save();

            return CreatedAtAction("GetSaleModel", new { id = saleModel.Id }, saleModel);
        }

        // DELETE: api/SaleAPI/5
        [HttpDelete("{id}")]
        public IActionResult DeleteSaleModel([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var saleModel = _storage.Get(id);
            if (saleModel == null)
            {
                return NotFound();
            }

            _storage.Remove(saleModel.Id);
            _storage.Save();

            return Ok(saleModel);
        }
    }
}