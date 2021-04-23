using Basket.API.Application.Services;
using Basket.API.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _service;

        public BasketController(IBasketService service)
        {
            _service = service;
        }

        [HttpGet("{username}")]
        public async Task<ShoppingCart> GetBasket(string username)
        {
            return await _service.GetBasketAsync(username) ?? new ShoppingCart(username);
        }

        [HttpPost]
        public async Task<ShoppingCart> UpdateBasket([FromBody] ShoppingCart basket)
        {
            return await _service.UpdateBasketAsync(basket);
        }

        [HttpDelete("{username}")]
        public async Task DeleteBasket(string username)
        {
            await _service.DeleteBasketAsync(username);
        }
    }
}
