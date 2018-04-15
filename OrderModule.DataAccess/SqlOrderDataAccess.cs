using OrderModule.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderModule.DataAccess
{
    public class SqlOrderDataAccess : IOrderDataAccess
    {
        public Task CancelOrderAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Order>> GetOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> RegisterOrderAsync(Order newOrder)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrderAsync(Order updatedOrder)
        {
            throw new NotImplementedException();
        }
    }
}