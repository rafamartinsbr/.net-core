using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookModule
{
    public interface IBookQueries
    {
        Task<Trade> GetLastTradeAsync();
        Task<IList<Trade>> GetTradesAsync();
        Task<Book> GetBookAsync(string instrument);
        Task<IList<Book>> GetBooksAsync();
    }
}