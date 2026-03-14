using BDF.LunchOrder.BL;
using BDF.LunchOrder.BL.Models;
using Plugin.LocalNotification;

namespace BDF.DVDCentral.MAUI
{
    public partial class LunchOrderPage : ContentPage
    {
        int count = 0;
        RadioButton[] mainDishRadioButtons = new RadioButton[3];
        CheckBox[] addOnDishCheckboxes = new CheckBox[3];
        Label[] addOnDishLabels = new Label[3];
        int whichMainDish;
        List<LunchItem> mainDishes;
        Label lblAddOnCost;
        //GroupBox gbxAddOns;


        public LunchOrderPage()
        {
            InitializeComponent();
            mainDishes = LunchItemManager.Populate();
            CreateScreen();
        }

        private void trigger_CallSignalR(object sender, SignalREventArgs e)
        {

            //Dispatcher.Invoke(() => { this.Title = e.Message; });
            //btnSendMessage.BeginInvoke((Action)(() => this.Text = e.Message));
            
            MainThread.BeginInvokeOnMainThread((Action)(() => Title = e.User + " ordered: " + e.Message));
            var request = new NotificationRequest
            {
                Title = $"New Message from {e.User}",
                Description = $"{e.Message}",
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

        async void OnButtonClicked(object sender, EventArgs e)
        {
            string user = "Frank";
            LunchItem mainDish = mainDishes[whichMainDish];
            string hubAddress = "https://fvtcdp.azurewebsites.net/BingoHub";
            hubAddress = "https://dvdcentralapi-120212964.azurewebsites.net/DVDCentralHub";
            var signalRClient = new SignalRClient(hubAddress);
            signalRClient.CallSignalR += new SignalRClient.SignalREventHandler(trigger_CallSignalR);

            signalRClient.ConnectToChannel(user);
            signalRClient.SendMessageToChannel(user, mainDish.Description);
        }

        public delegate void SignalREventHandler(object sender, SignalREventArgs e);
        public event SignalREventHandler CallSignalR;

        private void CreateScreen()
        {
            Border fraMain = new Border();

            StackLayout spMain = new StackLayout();
            spMain.Background = Colors.CornflowerBlue;
            spMain.Margin = new Thickness(0, 0, 0, 300);
            spMain.SetValue(Grid.ColumnProperty, 0);

            RadioButton rbtnMain1 = new RadioButton();
            //rbtnMain1.Name = "rbtnMain1";
            rbtnMain1.Margin = new Thickness(10, 17, 0, 0);
            rbtnMain1.Value = "0";
            rbtnMain1.Content = "Hamburgers";
            rbtnMain1.CheckedChanged += MainDishCheckedChanged;

            RadioButton rbtnMain2 = new RadioButton();
            //rbtnMain2.Name = "rbtnMain2";
            rbtnMain2.Margin = new Thickness(10, 17, 0, 0);
            rbtnMain2.Value = "1";
            rbtnMain2.Content = "Pizza";
            rbtnMain2.CheckedChanged += MainDishCheckedChanged;

            RadioButton rbtnMain3 = new RadioButton();
            rbtnMain3.Margin = new Thickness(10, 17, 0, 0);
            rbtnMain3.Value = "2";
            rbtnMain3.Content = "Salad";
            rbtnMain3.CheckedChanged += MainDishCheckedChanged;

            mainDishRadioButtons[0] = rbtnMain1;
            mainDishRadioButtons[1] = rbtnMain2;
            mainDishRadioButtons[2] = rbtnMain3;


            spMain.Children.Add(rbtnMain1);
            spMain.Children.Add(rbtnMain2);
            spMain.Children.Add(rbtnMain3);

            StackLayout spAddOns = new StackLayout();
            spAddOns.Margin = new Thickness(0, 0, 0, 300);
            spAddOns.Background = Colors.Purple;
            spAddOns.SetValue(Grid.ColumnProperty, 1);

            lblAddOnCost = new Label();
            lblAddOnCost.Margin = new Thickness(5, 5, 0, 0);
            lblAddOnCost.Text = "Add-On Cost";
            spAddOns.Children.Add(lblAddOnCost);

            CheckBox chkAddOn1 = new CheckBox();
            chkAddOn1.Margin = new Thickness(15);
            chkAddOn1.CheckedChanged += AddOnCheckedChanged;
            Label lblAddOn1 = new Label();
            lblAddOn1.Margin = new Thickness(55, 25, 0, 0);

            AbsoluteLayout addOnLayout1 = new AbsoluteLayout();
            addOnLayout1.Margin = new Thickness(5);
            addOnLayout1.Children.Add(lblAddOn1);
            addOnLayout1.Children.Add(chkAddOn1);

            CheckBox chkAddOn2 = new CheckBox();
            chkAddOn2.Margin = new Thickness(15);
            chkAddOn2.CheckedChanged += AddOnCheckedChanged;
            Label lblAddOn2 = new Label();
            lblAddOn2.Margin = new Thickness(55, 25, 0, 0);

            AbsoluteLayout addOnLayout2 = new AbsoluteLayout();
            addOnLayout2.Margin = new Thickness(5);
            addOnLayout2.Children.Add(lblAddOn2);
            addOnLayout2.Children.Add(chkAddOn2);

            CheckBox chkAddOn3 = new CheckBox();
            chkAddOn3.Margin = new Thickness(15);
            chkAddOn3.CheckedChanged += AddOnCheckedChanged;
            Label lblAddOn3 = new Label();
            lblAddOn3.Margin = new Thickness(55, 25, 0, 0);

            AbsoluteLayout addOnLayout3 = new AbsoluteLayout();
            addOnLayout3.Margin = new Thickness(5);
            addOnLayout3.Children.Add(lblAddOn3);
            addOnLayout3.Children.Add(chkAddOn3);

            spAddOns.Children.Add(addOnLayout1);
            spAddOns.Children.Add(addOnLayout2);
            spAddOns.Children.Add(addOnLayout3);

            addOnDishCheckboxes[0] = chkAddOn1;
            addOnDishCheckboxes[1] = chkAddOn2;
            addOnDishCheckboxes[2] = chkAddOn3;

            addOnDishLabels[0] = lblAddOn1;
            addOnDishLabels[1] = lblAddOn2;
            addOnDishLabels[2] = lblAddOn3;

            grdMain.Children.Add(spMain);
            grdMain.Children.Add(spAddOns);

        }

        private void MainDishCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            whichMainDish = Convert.ToInt32(((RadioButton)sender).Value);
            LunchItem mainDish = mainDishes[whichMainDish];
            double cost = mainDish.Cost;

            for (int i = 0; i <= addOnDishLabels.GetUpperBound(0); i++)
            {
                addOnDishCheckboxes[i].IsChecked = false;
                addOnDishLabels[i].Text = mainDish.AddOnItems[i].Description;
            }
            lblAddOnCost.Text = mainDish.AddOnText;
            double tax = cost * 0.055;
            lblTax.Text = tax.ToString("C");
            lblTotal.Text = (cost + tax).ToString("C");
            lblCost.Text = cost.ToString("C");
        }

        private void AddOnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            LunchItem mainDish = mainDishes[whichMainDish];
            double cost = mainDish.Cost;
            addOnDishCheckboxes.ToList().ForEach(item => {
                cost += (bool)item.IsChecked ? mainDish.AddOnCost : 0;
            });
            lblCost.Text = cost.ToString("C");
            double tax = cost * 0.055;
            lblTax.Text = tax.ToString("C");
            lblTotal.Text = (cost + tax).ToString("C");
        }


    }
}