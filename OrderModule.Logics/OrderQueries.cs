using OrderModule.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderModule.Logics
{
    public class OrderQueries : IOrderQueries
    {
        private readonly IOrderDataAccess _orderDataAccess;

        public OrderQueries(IOrderDataAccess orderDataAccess)
        {
            _orderDataAccess = orderDataAccess;
        }

        public async Task<Order> GetOrderAsync(int orderId)
        {
            return await _orderDataAccess.GetOrderAsync(orderId);
        }

        public async Task<IList<Order>> GetOrdersAsync()
        {
            return await _orderDataAccess.GetOrdersAsync();
        }
    }
}