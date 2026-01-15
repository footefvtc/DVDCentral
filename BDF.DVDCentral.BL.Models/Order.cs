using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BDF.DVDCentral.BL.Models
{
    public class Order
    {
        [DisplayName("Order #")]
        public Guid Id { get; set; }
        [DisplayName("Customer Id")]
        public Guid CustomerId { get; set; }
        [DisplayName("Customer Name")]
        public string CustomerFullName { get; set; } = string.Empty;
        [DisplayName("Order Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime OrderDate { get; set; }
        [DisplayName("Ship Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ShipDate { get; set; }
        [DisplayName("User Full Name")]
        public string UserFullName { get; set; } = string.Empty;
        [DisplayName("User Id")]
        public Guid UserId { get; set; }
        
        [DisplayName("Order Items")]
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Cost { get; set; }
        public int Quantity { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public double SubTotal 
        {
            get
            {
                float total = 0;
                foreach (var item in OrderItems)
                {
                    total += item.Cost * item.Quantity;
                }
                return total;
            }
        }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Tax { get { return SubTotal * 0.055; } }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Total { get { return SubTotal + Tax; } }
    }
}
