namespace BDF.LunchOrder.BL.Models
{
    public class LunchItem
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string ItemText
        {
            get { return $"{description} - {cost.ToString("C")}"; }
        }

        private string description = string.Empty;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private double cost;

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        private double addOnCost;

        public double AddOnCost
        {
            get { return addOnCost; }
            set { addOnCost = value; }
        }

        private List<AddOnItem> addOnItems = new List<AddOnItem>();

        public List<AddOnItem> AddOnItems
        {
            get { return addOnItems; }
            set { addOnItems = value; }
        }

        public string AddOnText { get { return "Add-on items (" + addOnCost.ToString("C") + "/each)"; } }
    }
}
