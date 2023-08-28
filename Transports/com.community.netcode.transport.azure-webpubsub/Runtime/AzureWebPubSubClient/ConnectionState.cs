namespace Netcode.Transports.AzureRealtime
{
    public enum ConnectionState
    {
        Init,
        Connecting,
        Connected,
        ConnectFailed,
        Disconnected,
        Stopping,
        Stopped,
        StopFailed,
        RejoinGroupFailed,
    }
}