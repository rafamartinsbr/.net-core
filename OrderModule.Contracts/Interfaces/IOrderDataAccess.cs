using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderModule.Contracts
{
    public interface IOrderDataAccess
    {
        Task<int> RegisterOrderAsync(Order newOrder);
        Task UpdateOrderAsync(Order updatedOrder);
        Task CancelOrderAsync(int orderId);
        Task<Order> GetOrderAsync(int orderId);
        Task<IList<Order>> GetOrdersAsync();
    }
}