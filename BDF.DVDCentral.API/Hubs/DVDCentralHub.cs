using Microsoft.AspNetCore.SignalR;

namespace BDF.DVDCentral.API.Hubs
{
    public class DVDCentralHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            // BL Calls!

            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
