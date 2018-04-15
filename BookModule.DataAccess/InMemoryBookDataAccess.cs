using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookModule.DataAccess
{
    public class InMemoryBookDataAccess : IBookDataAccess
    {
        private readonly object _locker;
        private Dictionary<string, Book> _books;

        //old fashion class with reaaaally simple implementation here...
        //not using ConcurrentDictionary and ignoring any complexity since it's more like a mock/prototype class

        public InMemoryBookDataAccess()
        {
            _locker = new object();
            _books = new Dictionary<string, Book>();
        }

        public async Task ClearBookAsync(string instrument)
        {
            lock (_locker)
                _books.Clear();

            await Task.CompletedTask;
        }

        public async Task<Book> GetBookAsync(string instrument)
        {
            Book book;

            lock (_locker)
                book = _books[instrument];

            return await Task.FromResult(book);
        }

        public async Task<IList<Book>> GetBooksAsync()
        {
            IList<Book> books;

            lock (_locker)
                books = _books.Values.ToList();

            return await Task.FromResult(books);
        }

        public Task<Trade> GetLastTradeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Trade>> GetTradesAsync()
        {
            throw new NotImplementedException();
        }
    }
}