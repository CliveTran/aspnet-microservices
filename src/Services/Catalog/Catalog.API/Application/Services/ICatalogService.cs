using Catalog.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Application.Services
{
    public interface ICatalogService
    {
        Task<Product> GetProductByIdAsync(Guid id);

        Task<Product> CreateProductAsync(Product product);

        Task<IEnumerable<Product>> GetAllProductsAsync();

        Task DeleteProductAsync(Guid id);

        Task UpdateProductAsync(Product product);
    }
}
