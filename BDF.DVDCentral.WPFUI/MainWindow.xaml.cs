using BDF.LunchOrder.BL;
using BDF.LunchOrder.BL.Models;
using System.Windows;
using System.Windows.Controls;

namespace BDF.DVDCentral.WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RadioButton[] mainDishRadioButtons = new RadioButton[3];
        CheckBox[] addOnDishCheckboxes = new CheckBox[3];
        int whichMainDish;
        List<LunchItem> mainDishes;

        public MainWindow()
        {
            InitializeComponent();
            mainDishes = LunchItemManager.Populate();
            var mainRadioButtons = spMain.Children;
            var addOnCheckboxes = spAddOns.Children;

            foreach (var rb in mainRadioButtons)
            {
                RadioButton rbtnMainDish = (rb as RadioButton)!;
                int index = Convert.ToInt32(rbtnMainDish.Tag);
                mainDishRadioButtons[index] = rbtnMainDish;
                rbtnMainDish.Content = mainDishes[index].ItemText;
            }

            foreach (var cb in addOnCheckboxes)
            {
                CheckBox cbxAddOn = (cb as CheckBox)!;
                int index = Convert.ToInt32(cbxAddOn.Tag);
                addOnDishCheckboxes[index] = cbxAddOn;
            }

        }

        private void MainDishCheckedChanged(object sender, RoutedEventArgs e)
        {
            whichMainDish = Convert.ToInt32(((RadioButton)sender).Tag);
            LunchItem mainDish = mainDishes[whichMainDish];
            double cost = mainDish.Cost;
            addOnDishCheckboxes.ToList().ForEach(item =>
            {
                item.Content = mainDish.AddOnItems[Convert.ToInt32(item.Tag)].Description;
                item.IsChecked = false;
            });
            gbxAddOn.Header = mainDish.AddOnText;
            lblCost.Content = cost.ToString("C");
        }

        private void AddOnCheckedChanged(object sender, RoutedEventArgs e)
        {
            LunchItem mainDish = mainDishes[whichMainDish];
            double cost = mainDish.Cost;
            addOnDishCheckboxes.ToList().ForEach(item => {
                cost += (item.IsChecked == true) ? mainDish.AddOnCost : 0;
            });
            lblCost.Content = cost.ToString("C");
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string user = "Burt";
            LunchItem mainDish = mainDishes[whichMainDish];
            string hubAddress = "https://fvtcdp.azurewebsites.net/BingoHub";
            //hubAddress = "https://localhost:7156/dvdcentralhub";
            var signalRClient = new SignalRClient(hubAddress);
            signalRClient.CallSignalR += new SignalRClient.SignalREventHandler(trigger_CallSignalR);

            signalRClient.ConnectToChannel(user);
            signalRClient.SendMessageToChannel(user, mainDish.Description);
        }

        private void trigger_CallSignalR(object sender, SignalREventArgs e)
        {
            // Catch the user and message
            // Display on the correct UI thread.

            //this.Text = e.Message;
            Dispatcher.Invoke(() => { this.Title = e.Message; });
        }


    }
}