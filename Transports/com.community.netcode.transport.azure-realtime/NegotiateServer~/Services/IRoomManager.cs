using System.Threading.Tasks;

namespace NegotiateServer.Services
{
    public interface IRoomManager
    {
        public Task<bool> ExistAsync(string roomId);
    }
}