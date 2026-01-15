using System.ComponentModel;

namespace BDF.DVDCentral.BL.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Customer Name")]
        public string CustomerFullName { get { return FirstName + " " + LastName; } }
        public int UserId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        [DisplayName("Image")]
        public string ImagePath { get; set; }
    }
}
