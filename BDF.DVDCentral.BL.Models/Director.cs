using System.ComponentModel;

namespace BDF.DVDCentral.BL.Models
{
    public class Director
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }

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
