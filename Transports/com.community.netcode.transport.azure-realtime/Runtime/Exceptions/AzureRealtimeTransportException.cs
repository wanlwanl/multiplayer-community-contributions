using System;

namespace Netcode.Transports.AzureRealtime
{
    public class AzureRealtimeTransportException : Exception
    {
        public AzureRealtimeTransportException(string message) : base(message)
        { }
    }
}