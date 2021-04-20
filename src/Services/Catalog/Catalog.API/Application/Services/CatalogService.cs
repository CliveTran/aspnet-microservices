using Catalog.API.Domain.Entities;
using Catalog.API.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
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

        public async Task<Product> CreateProductAsync(Product product)
        {
            await _productRepository.CreateAsync(product);

            return await GetProductByIdAsync(product.Id);
        }

        public async Task DeleteProductAsync(Guid id)
        {
            await _productRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _productRepository.UpdateAsync(product);
        }
    }
}
