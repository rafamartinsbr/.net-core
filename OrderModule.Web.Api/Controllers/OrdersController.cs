using Microsoft.AspNetCore.Mvc;
using OrderModule.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookModule.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly IOrderQueries _orderQueries;
        private readonly IOrderCommands _orderCommands;

        public OrdersController(IOrderQueries orderQueries, IOrderCommands orderCommands)
        {
            _orderQueries = orderQueries;
            _orderCommands = orderCommands;
        }

        // GET api/orders
        [HttpGet]
        public async Task<IEnumerable<Order>> Get()
        {
            var orderCollection = await _orderQueries.GetOrdersAsync();

            return orderCollection;
        }

        // GET api/orders/5
        [HttpGet("{id}")]
        public async Task<Order> Get(int orderId)
        {
            var order = await _orderQueries.GetOrderAsync(orderId);

            return order;
        }

        // POST api/order
        [HttpPost]
        public async Task<int> Post([FromBody]Order newOrder)
        {
            var resourceId = await _orderCommands.RegisterOrderAsync(newOrder);

            return resourceId;
        }

        // PUT api/order/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody]Order updatedOrder)
        {
            await _orderCommands.UpdateOrderAsync(updatedOrder);
        }

        // DELETE api/order/5
        [HttpDelete("{id}")]
        public async Task Delete(int orderId)
        {
            await _orderCommands.CancelOrderAsync(orderId);
        }
    }
}