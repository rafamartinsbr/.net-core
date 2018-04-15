using System.Threading.Tasks;

namespace BookModule.Logics
{
    public class BookCommands : IBookCommands
    {
        private readonly IBookQueries _BookQueries;
        private readonly IBookDataAccess _BookDataAccess;

        public BookCommands(IBookQueries BookQueries, IBookDataAccess BookDataAccess)
        {
            _BookQueries = BookQueries;
            _BookDataAccess = BookDataAccess;
        }

        public async Task ClearBookAsync(string instrument)
        {
            await _BookDataAccess.ClearBookAsync(instrument);
        }
    }
}