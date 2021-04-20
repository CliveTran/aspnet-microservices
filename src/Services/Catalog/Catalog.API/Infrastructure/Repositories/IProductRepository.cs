using Catalog.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Infrastructure.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();

        Task<Product> GetByIdAsync(Guid id);

        Task<IEnumerable<Product>> GetByNameAsync(string name);

        Task<IEnumerable<Product>> GetByCategoryNameAsync(string name);

        Task CreateAsync(Product product);

        Task<bool> UpdateAsync(Product product);

        Task<bool> DeleteAsync(Guid id);
    }
}
