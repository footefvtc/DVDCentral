using System.ComponentModel;

namespace BDF.DVDCentral.BL.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; } = string.Empty;
        [DisplayName("Last Name")]
        public string LastName { get; set; } = string.Empty;
        [DisplayName("Customer Name")]
        public string CustomerFullName { get { return FirstName + " " + LastName; } }
        public int UserId { get; set; }
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        [DisplayName("Image")]
        public string ImagePath { get; set; } = string.Empty;
    }
}
