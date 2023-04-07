namespace Netcode.Transports.AzureRealtime
{
    public class NegotiateException : AzureRealtimeTransportException
    {
        public NegotiateException(string message) : base(message)
        { }
    }
}