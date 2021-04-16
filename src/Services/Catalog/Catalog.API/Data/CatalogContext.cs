using Catalog.API.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            Database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            Products = Database.GetCollection<Product>(configuration.GetValue<string>("CollectionName"));
            CatalogContextSeeder.SeedData(Products);
        }

        public IMongoDatabase Database { get; set; }
        public IMongoCollection<Product> Products { get; }
    }
}
