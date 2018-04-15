using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderModule.Contracts
{
    public interface IOrderQueries
    {
        Task<Order> GetOrderAsync(int orderId);
        Task<IList<Order>> GetOrdersAsync();
    }
}