using System.ComponentModel;

namespace BDF.DVDCentral.BL.Models
{
    public class Director
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; } = string.Empty;
        [DisplayName("Last Name")]
        public string LastName { get; set; } = string.Empty;

        // Calculated field
        public string FullName 
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
