using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public interface ICatalogContext
    {
        IMongoDatabase Database { get; }
        IMongoCollection<Product> Products { get; }
    }
}
