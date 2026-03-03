using BDF.LunchOrder.BL.Models;
using FVTC.Utility;
using System.Diagnostics;
using System.Reflection;

namespace BDF.DVDCentral.WinFormUI
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

            string className = MethodBase.GetCurrentMethod()!.DeclaringType!.Name;
            // Do UI stuff.
            Debug.WriteLine($"{className}:{user}: {message}");

            User = user;
            Message = message;

            SignalREventArgs signalREventArgs = new SignalREventArgs();
            signalREventArgs.User = user;
            signalREventArgs.Message = message;
            CallSignalR(new object(), signalREventArgs);


        }

        public delegate void SignalREventHandler(object sender, SignalREventArgs e);
        public event SignalREventHandler CallSignalR;
    }
}
