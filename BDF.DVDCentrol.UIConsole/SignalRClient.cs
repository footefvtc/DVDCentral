using FVTC.Utility;

namespace BDF.DVDCentrol.UIConsole
{
    public class SignalRClient : SignalRConnection
    {
        public SignalRClient(string hubAddress) : base(hubAddress) 
        {

        }

        public SignalRClient(string hubAddress, string owner) : base(hubAddress, owner)
        {

        }

        public override void OnSend(string user, string message)
        {
            Console.WriteLine($"{user}: {message}");
        }
    }
}
