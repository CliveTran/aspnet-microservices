using Catalog.API.Domain.Entities;
using Catalog.API.Infrastructure.Repositories;
using System;
using System.Threading.Tasks;

namespace Catalog.API.Application.Services
{
    public class CatalogService : ICatalogService
    {
        public readonly IProductRepository _productRepository;

        public CatalogService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<Product> CreateProduct(Product product)
        {
            _productRepository.Create(product);
            return Task.FromResult(product);
        }

        public Task<Product> GetProduct(Guid id)
        {
            return _productRepository.GetById(id);
        }
    }
}
