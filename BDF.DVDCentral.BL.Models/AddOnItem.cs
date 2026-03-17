namespace BDF.LunchOrder.BL.Models
{
    public class AddOnItem
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string description = string.Empty;

        public string Description
        {
            get { return description; }
            set { description = value; }
        } 


    }
}
