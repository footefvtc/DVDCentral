using BDF.LunchOrder.BL;
using BDF.LunchOrder.BL.Models;

namespace BDF.DVDCentral.WinFormUI
{
    public partial class frmLunchOrder : Form
    {
        RadioButton[] mainDishRadioButtons = new RadioButton[3];
        CheckBox[] addOnCheckboxes = new CheckBox[3];
        int whichMainDish;
        List<LunchItem> mainDishes = LunchItemManager.Populate();
       
        public frmLunchOrder()
        {
            InitializeComponent();

            for (int index = mainDishRadioButtons.GetLowerBound(0); index <= mainDishRadioButtons.GetUpperBound(0); index++)
            {
                mainDishRadioButtons[index] = (RadioButton)gbxMain.Controls["rbtnMain" + (index + 1).ToString()]!;
                mainDishRadioButtons[index].Text = mainDishes[index].ItemText;
                addOnCheckboxes[index] = (CheckBox)this.gbxAddOn.Controls["cbxAddOn" + (index + 1).ToString()]!;
            }
        }
        private void AddOn_CheckedChanged(object sender, EventArgs e)
        {
            LunchItem mainDish = mainDishes[whichMainDish];
            double cost = mainDish.Cost;
            addOnCheckboxes.ToList().ForEach(item => cost += item.Checked ? mainDish.AddOnCost : 0);
            lblCost.Text = cost.ToString("C");
        }
        private void mainDish_CheckedChanged(object sender, EventArgs e)
        {
            whichMainDish = ((RadioButton)sender).TabIndex;
            LunchItem mainDish = mainDishes[whichMainDish];

            addOnCheckboxes.ToList().ForEach(item =>
            {
                item.Text = mainDish.AddOnItems[item.TabIndex].Description;
                item.Checked = false;
            });

            gbxAddOn.Text = mainDish.AddOnText;
            AddOn_CheckedChanged(sender, e);
        }
        private void trigger_CallSignalR(object sender, SignalREventArgs e)
        {
            // Catch the user and message
            // Display on the correct UI thread.

            //this.Text = e.Message;
            btnPlaceOrder.BeginInvoke((Action)(() => this.Text = e.Message));
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string user = "Brian";
            LunchItem mainDish = mainDishes[whichMainDish];
            string hubAddress = "https://fvtcdp.azurewebsites.net/BingoHub";
            //hubAddress = "https://localhost:7156/dvdcentralhub";

            var signalRClient = new SignalRClient(hubAddress);
            signalRClient.CallSignalR += new SignalRClient.SignalREventHandler(trigger_CallSignalR);

            signalRClient.ConnectToChannel(user);
            signalRClient.SendMessageToChannel(user, mainDish.Description);
        }
    }
}

