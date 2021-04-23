using Basket.API.Domain.Entities;
using System.Threading.Tasks;

namespace Basket.API.Application.Services
{
    public interface IBasketService
    {
        Task<ShoppingCart> GetBasketAsync(string username);
        Task<ShoppingCart> UpdateBasketAsync(ShoppingCart basket);
        Task DeleteBasketAsync(string username);
    }
}
