using System.ComponentModel;

namespace BDF.DVDCentral.BL.Models
{
    /// <summary>
    /// Represents a customer and provides access to their personal and contact information.
    /// </summary>
    /// <remarks>The Customer class encapsulates details such as the customer's name, address, phone number,
    /// and associated user identifier. The CustomerFullName property combines the first and last names for convenience.
    /// This class is typically used to store and retrieve customer information within the application.</remarks>
    public class Customer
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Gets or sets the first name of the customer.[DisplayName("First Name")]
        /// </summary>
        public string FirstName { get; set; } = string.Empty;
        [DisplayName("Last Name")]
        public string LastName { get; set; } = string.Empty;
        [DisplayName("Customer Name")]
        public string CustomerFullName { get { return FirstName + " " + LastName; } }
        public Guid UserId { get; set; }
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        [DisplayName("Image")]
        public string ImagePath { get; set; } = string.Empty;
    }
}
