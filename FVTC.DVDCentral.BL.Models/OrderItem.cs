using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FVTC.DVDCentral.BL.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        [DisplayName("Order #")]
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        [DisplayName("Movie Id")]
        public int MovieId { get; set; }
        [DisplayName("Movie Title")]
        public string Title { get; set; }
        [DisplayName("Image")]
        public string ImagePath { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public float Cost { get; set; }
    }
}
