using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FVTC.DVDCentral.BL.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int FormatId { get; set; }
        public int DirectorId { get; set; }
        public int RatingId { get; set; }
        [DisplayName("Rating")]
        public string RatingDescription { get; set; }
        [DisplayName("Format")]
        public string FormatDescription { get; set; }
        [DisplayName("Director Name")]
        public string DirectorFullName { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public float Cost { get; set; }
        [DisplayName("Cost")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public float CostTotal { get { return Cost * Count; } }
        [DisplayName("Quantity In Stock")]
        public int InStkQty { get; set; }
        [DisplayName("Image")]
        public string ImagePath { get; set; }
        public List<Genre> Genres { get; set; }
        [DisplayName("Quantity")]
        public int Count { get; set; }
    }
}
