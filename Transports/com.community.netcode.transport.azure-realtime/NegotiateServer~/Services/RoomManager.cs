using Azure.Messaging.WebPubSub;
using System.Threading.Tasks;

namespace NegotiateServer.Services
{
    internal class RoomManager : IRoomManager
    {
        private WebPubSubServiceClient _serviceClient;

        public RoomManager(WebPubSubServiceClient serviceClient)
        {
            _serviceClient = serviceClient;
        }

        public async Task<bool> ExistAsync(string roomId)
        {
            var res = await _serviceClient.UserExistsAsync(roomId);
            return res.Value;
        }
    }
}