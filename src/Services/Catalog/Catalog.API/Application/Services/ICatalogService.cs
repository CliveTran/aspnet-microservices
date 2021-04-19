using Catalog.API.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Catalog.API.Application.Services
{
    public interface ICatalogService
    {
        Task<Product> GetProduct(Guid id);

        Task<Product> CreateProduct(Product product);
    }
}
