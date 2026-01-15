using System.ComponentModel;

namespace BDF.DVDCentral.BL.Models
{
    public class User
    {
        public int Id { get; set; }
        [DisplayName("UserId")]
        public string UserId { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Password { get; set; }
        [DisplayName("User Full Name")]
        public string UserFullName { get {  return FirstName + " " + LastName; } }
    }
}
