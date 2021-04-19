using Catalog.API.Domain.Entities;
using MongoDB.Driver;

namespace Catalog.API.Infrastructure.Data
{
    public interface ICatalogContext
    {
        IMongoDatabase Database { get; }
        IMongoCollection<Product> Products { get; }
    }
}
