using OrderModule.Contracts;
using System.Threading.Tasks;

namespace OrderModule.Logics
{
    public class OrderCommands : IOrderCommands
    {
        private readonly IOrderDataAccess _orderDataAccess;

        public OrderCommands(IOrderDataAccess orderDataAccess)
        {
            _orderDataAccess = orderDataAccess;
        }

        public async Task<int> RegisterOrderAsync(Order newOrder)
        {
            return await _orderDataAccess.RegisterOrderAsync(newOrder);
        }

        public async Task UpdateOrderAsync(Order updatedOrder)
        {
            await _orderDataAccess.UpdateOrderAsync(updatedOrder);
        }

        public async Task CancelOrderAsync(int orderId)
        {
            await _orderDataAccess.CancelOrderAsync(orderId);
        }
    }
}