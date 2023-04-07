using Netcode.Transports.AzureRealtime;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace NegotiateServer.Services
{
    internal class ConnectionContextGenerator : IConnectionContextGenerator
    {
        private ulong _nextId = 0;

        public Task<ConnectionContext> NextAsync(string roomId, bool isServer)
        {
            if (isServer)
            {
                return Task.FromResult(new ConnectionContext()
                {
                    UClientId = 0,
                    SubChannel = roomId,
                    PubChannel = null,
                });
            }

            var curId = Interlocked.Increment(ref _nextId);
            return Task.FromResult(new ConnectionContext()
            {
                UClientId = curId,
                SubChannel = Guid.NewGuid().ToString("N"),
                PubChannel = roomId,
            });
        }
    }
}