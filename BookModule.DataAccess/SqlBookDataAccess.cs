using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookModule.DataAccess
{
    public class SqlBookDataAccess : IBookDataAccess
    {
        public Task ClearBookAsync(string instrument)
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookAsync(string instrument)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Book>> GetBooksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Trade>> GetTradesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Trade> GetLastTradeAsync()
        {
            throw new NotImplementedException();
        }
    }
}