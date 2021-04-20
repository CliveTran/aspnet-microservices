using Catalog.API.Application.Services;
using Catalog.API.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogService _service;

        public CatalogController(ICatalogService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<Product> GetProduct(Guid id)
        {
            return await _service.GetProductByIdAsync(id);
        }

        [HttpPost]
        public async Task<Product> CreateProduct(Product product)
        {
            return await _service.CreateProductAsync(product);
        }

        [HttpGet("all")]
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _service.GetAllProductsAsync();
        }

        [HttpDelete]
        public async Task DeleteProduct(Guid id)
        {
            await _service.DeleteProductAsync(id);
        }

        [HttpPut]
        public async Task UpdateProduct(Product product)
        {
            await _service.UpdateProductAsync(product);
        }
    }
}
