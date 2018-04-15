using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookModule
{
    public interface IBookDataAccess
    {
        Task ClearBookAsync(string instrument);
        Task<Book> GetBookAsync(string instrument);
        Task<IList<Book>> GetBooksAsync();
        Task<Trade> GetLastTradeAsync();
        Task<IList<Trade>> GetTradesAsync();
    }
}