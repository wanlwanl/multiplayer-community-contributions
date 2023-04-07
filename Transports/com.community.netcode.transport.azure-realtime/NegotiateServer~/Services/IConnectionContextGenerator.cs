using Netcode.Transports.AzureRealtime;

namespace NegotiateServer.Services
{
    internal interface IConnectionContextGenerator
    {
        public Task<ConnectionContext> NextAsync(string roomId, bool isServer);
    }
}