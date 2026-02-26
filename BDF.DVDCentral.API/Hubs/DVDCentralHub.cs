using Microsoft.AspNetCore.SignalR;
namespace BDF.DVDCentral.API.Hubs
{
    public class DVDCentralHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
