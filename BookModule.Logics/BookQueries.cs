using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookModule.Logics
{
    public class BookQueries : IBookQueries
    {
        private readonly IBookDataAccess _bookDataAccess;

        public BookQueries(IBookDataAccess bookDataAccess)
        {
            _bookDataAccess = bookDataAccess;
        }

        public Task<Trade> GetLastTradeAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Book> GetBookAsync(string instrument)
        {
            return await _bookDataAccess.GetBookAsync(instrument);
        }

        public async Task<IList<Book>> GetBooksAsync()
        {
            return await _bookDataAccess.GetBooksAsync();
        }

        public Task<IList<Trade>> GetTradesAsync()
        {
            throw new NotImplementedException();
        }
    }
}