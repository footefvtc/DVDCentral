using System.ComponentModel;

namespace BDF.DVDCentral.BL.Models
{
    public class User
    {
        public Guid Id { get; set; }
        [DisplayName("UserId")]
        public string UserId { get; set; } = string.Empty;
        [DisplayName("First Name")]
        public string FirstName { get; set; } = string.Empty;
        [DisplayName("Last Name")]
        public string LastName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        [DisplayName("User Full Name")]
        public string UserFullName { get {  return FirstName + " " + LastName; } }
    }
}
