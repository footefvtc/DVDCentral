using System.ComponentModel.DataAnnotations;

namespace FVTC.DVDCentral.BL.Models
{
    public class ShoppingCart
    {
        public double Cost { get; }
        public List<Movie> Items { get; set; } = new List<Movie>();

        public int NumberOfItems { get { return Items.Sum(t=>t.Count); } }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public double SubTotal
        {
            get
            {
                float total = 0;
                foreach (var item in Items)
                    total += item.CostTotal;
                return total;
            }
        }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Tax { get { return SubTotal * 0.055; } }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Total { get { return SubTotal + Tax; } }

        public int CustomerId { get; set; }
        public int UserId { get; set; }
    }
}
