using Catalog.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Infrastructure.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();

        Task<Product> GetById(Guid id);

        Task<IEnumerable<Product>> GetByName(string name);

        Task<IEnumerable<Product>> GetByCategoryName(string name);

        Task Create(Product product);

        Task<bool> Update(Product product);

        Task<bool> Delete(Guid id);
    }
}
