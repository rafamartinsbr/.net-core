using System.Threading.Tasks;

namespace BookModule
{
    public interface IBookCommands
    {
        Task ClearBookAsync(string instrument);
    }
}