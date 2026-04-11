using Plugin.LocalNotification;
using Plugin.LocalNotification.Core.Models;

namespace BDF.DVDCentral.MAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

            var request = new NotificationRequest
            {
                Title = "Counter Clicked",
                Description = $"You have clicked the counter {count} times.",
                ReturningData = "Dummy data", // Returning data when tapped on notification.
                //NotifyTime = DateTime.Now.AddSeconds(5) // Schedule the notification to appear after 5 seconds.
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = DateTime.Now.AddSeconds(5) // Schedule the notification to appear after 5 seconds.
                }
            };

            if (!LocalNotificationCenter.Current.AreNotificationsEnabled().Result)
            {
                if (LocalNotificationCenter.Current.RequestNotificationPermission().Result)
                {
                    LocalNotificationCenter.Current.Show(request);
                }
            }
            else
            {
                LocalNotificationCenter.Current.Show(request);
            }



        }

    }
}
