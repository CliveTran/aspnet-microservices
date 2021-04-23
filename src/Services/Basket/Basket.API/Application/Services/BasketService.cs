using Basket.API.Domain.Entities;
using Basket.API.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Application.Services
{
    public class BasketService : IBasketService
    {
        private readonly IBasketRepository _repo;

        public BasketService(IBasketRepository repo)
        {
            _repo = repo;
        }
        public async Task DeleteBasketAsync(string username)
        {
            await _repo.DeleteBasketAsync(username);
        }

        public async Task<ShoppingCart> GetBasketAsync(string username)
        {
            return await _repo.GetBasketAsync(username);
        }

        public async Task<ShoppingCart> UpdateBasketAsync(ShoppingCart basket)
        {
            return await _repo.UpdateBasketAsync(basket);
        }
    }
}
