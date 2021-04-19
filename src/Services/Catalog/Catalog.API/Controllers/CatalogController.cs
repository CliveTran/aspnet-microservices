using Catalog.API.Application.Services;
using Catalog.API.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogService _service;
        private readonly ILogger<CatalogController> _logger;

        public CatalogController(ICatalogService service, ILogger<CatalogController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<Product> GetProduct(Guid id)
        {
            return await _service.GetProduct(id);
        }

        [HttpPost]
        public async Task<Product> CreateProduct(Product product)
        {
            return await _service.CreateProduct(product);
        }
    }
}
