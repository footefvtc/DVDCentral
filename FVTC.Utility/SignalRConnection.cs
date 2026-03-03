using Microsoft.AspNetCore.SignalR.Client;

namespace FVTC.Utility
{
    public abstract class SignalRConnection
    {
        private string hubAddress;
        HubConnection connection;

        public string User { get; set; }
        public string Message { get; set; }

        string owner;
        public SignalRConnection(string hubAddress)
        {
            this.hubAddress = hubAddress;
        }

        public SignalRConnection(string hubAddress, string owner)
        {
            this.hubAddress = hubAddress;
            this.owner = owner;
        }

        public HubConnection HubConnection
        {
            get { return connection; } 
        }

        public void Start()
        {
            connection = new HubConnectionBuilder()
                .WithUrl(hubAddress)
                .Build();
            connection.On<string, string>("ReceiveMessage", (s1, s2) => OnSend(s1, s2));
            connection.StartAsync();
        }

        public void Stop()
        {
            connection.StopAsync();
        }

        public void ConnectToChannel(string user)
        {
            try
            {
                Start();
                string message = user + " connected...";
                connection.InvokeAsync("SendMessage", "System", message);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SendMessageToChannel(string user, string message)
        {
            try
            {
                connection.InvokeAsync("SendMessage", user, message);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public abstract void OnSend(string user, string message);

    }
}
