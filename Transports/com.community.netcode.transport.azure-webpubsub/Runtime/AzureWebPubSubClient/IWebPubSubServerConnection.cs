using Cysharp.Threading.Tasks;

namespace Netcode.Transports.AzureRealtime
{
    internal interface IWebPubSubServerConnection : IWebPubSubConnection
    {
        public void AbortUClient(ulong uClientId);
    }
}