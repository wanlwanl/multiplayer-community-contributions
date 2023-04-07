using Cysharp.Threading.Tasks;

namespace Netcode.Transports.AzureRealtime
{
    internal interface IWebPubSubClientConnection : IWebPubSubConnection
    {
        public UniTask SendDisconnectEventToServer();
    }
}