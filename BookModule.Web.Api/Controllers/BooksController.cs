using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookModule.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly IBookQueries _bookQueries;
        private readonly IBookCommands _bookCommands;

        public BooksController(IBookQueries bookQueries, IBookCommands bookCommands)
        {
            _bookQueries = bookQueries;
            _bookCommands = bookCommands;
        }

        // GET api/books
        [HttpGet]
        public async Task<IEnumerable<Book>> Get()
        {
            var bookCollection = await _bookQueries.GetBooksAsync();

            return bookCollection;
        }

        // GET api/books/5
        [HttpGet("{id}")]
        public async Task<Book> Get(string instrument)
        {
            var book = await _bookQueries.GetBookAsync(instrument);

            return book;
        }
    }
}