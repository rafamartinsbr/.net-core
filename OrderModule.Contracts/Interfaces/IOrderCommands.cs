using System.Threading.Tasks;

namespace OrderModule.Contracts
{
    public interface IOrderCommands
    {
        Task<int> RegisterOrderAsync(Order value);
        Task UpdateOrderAsync(Order updatedOrder);
        Task CancelOrderAsync(int orderId);
    }
}