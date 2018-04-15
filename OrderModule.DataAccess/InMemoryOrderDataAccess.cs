using OrderModule.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderModule.DataAccess
{
    public class InMemoryOrderDataAccess : IOrderDataAccess
    {
        private readonly object _locker;
        private Dictionary<int, Order> _orders;
        private int _lastId;

        //old fashion class with reaaaally simple implementation here...
        //not using ConcurrentDictionary and ignoring any complexity since it's more like a mock/prototype class

        public InMemoryOrderDataAccess()
        {
            _locker = new object();
            _orders = new Dictionary<int, Order>();
        }

        public async Task CancelOrderAsync(int orderId)
        {
            lock (_locker)
                _orders.Remove(orderId);

            await Task.CompletedTask;
        }

        public async Task<Order> GetOrderAsync(int orderId)
        {
            Order order;

            lock (_locker)
                order = _orders[orderId];

            return await Task.FromResult(order);
        }

        public async Task<IList<Order>> GetOrdersAsync()
        {
            IList<Order> orders;

            lock (_locker)
                orders = _orders.Values.ToList();

            return await Task.FromResult(orders);
        }

        public async Task<int> RegisterOrderAsync(Order newOrder)
        {
            int id;

            lock (_locker)
            {
                id = ++_lastId;
                _orders.Add(id, newOrder);
                newOrder.OrderId = id;
            }

            return await Task.FromResult(id);
        }

        public async Task UpdateOrderAsync(Order updatedOrder)
        {
            lock (_locker)
                _orders[updatedOrder.OrderId] = updatedOrder;

            await Task.CompletedTask;
        }
    }
}