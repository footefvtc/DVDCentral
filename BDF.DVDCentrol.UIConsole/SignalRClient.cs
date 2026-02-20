
using BDF.DVDCentral.BL.Models;
using FVTC.Utility;

namespace BDF.DVDCentral.UIConsole
{
    public class SignalRClient : SignalRConnection
    {
        public SignalRClient(string hubAddres) : base(hubAddres)
        {

        }
        public SignalRClient(string hubAddres, string owner) : base(hubAddres, owner)
        {

        }

        public override void OnSend(string user, string message)
        {
            Console.WriteLine($"{user}: {message}");
            User = user;
            Message = message;
        }
    }
}
