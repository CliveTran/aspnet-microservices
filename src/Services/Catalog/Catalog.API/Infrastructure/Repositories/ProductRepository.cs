using Catalog.API.Domain.Entities;
using Catalog.API.Infrastructure.Data;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICatalogContext _context;
        public ProductRepository(ICatalogContext context)
        {
            _context = context;
        }
        public async Task Create(Product product)
        {
            await _context.Products.InsertOneAsync(product);
        }

        public async Task<bool> Delete(Guid id)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Id, id);

            var updateResult = await _context.Products.DeleteOneAsync(filter);
            return updateResult.IsAcknowledged && updateResult.DeletedCount > 0;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products.Find(p => true).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetByCategoryName(string categoryName)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Category, categoryName);

            return await _context.Products.Find(filter).ToListAsync();
        }

        public async Task<Product> GetById(Guid id)
        {
            return await _context.Products.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetByName(string name)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Name, name);

            return await _context.Products.Find(filter).ToListAsync();
        }

        public async Task<bool> Update(Product product)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Id, product.Id);

            var updateResult = await _context.Products.ReplaceOneAsync(filter, product);
            return updateResult.IsAcknowledged && updateResult.ModifiedCount > 0;
        }
    }
}
