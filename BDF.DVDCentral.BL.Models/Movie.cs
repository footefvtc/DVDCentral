using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BDF.DVDCentral.BL.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid FormatId { get; set; }
        public Guid DirectorId { get; set; }
        public Guid RatingId { get; set; }
        [DisplayName("Rating")]
        public string RatingDescription { get; set; } = string.Empty;
        [DisplayName("Format")]
        public string FormatDescription { get; set; } = string.Empty;
        [DisplayName("Director Name")]
        public string DirectorFullName { get; set; } = string.Empty;
        [DisplayFormat(DataFormatString = "{0:C}")]
        public float Cost { get; set; }
        [DisplayName("Cost")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public float CostTotal { get { return Cost * Count; } }
        [DisplayName("Quantity In Stock")]
        public int InStkQty { get; set; }
        [DisplayName("Image")]
        public string ImagePath { get; set; } = string.Empty;
        public List<Genre> Genres { get; set; } = new List<Genre>();
        [DisplayName("Quantity")]
        public int Count { get; set; }
    }
}
