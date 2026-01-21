namespace BDF.DVDCentral.PL.Entities;

public partial class tblMovie
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid FormatId { get; set; }

    public Guid DirectorId { get; set; }

    public Guid RatingId { get; set; }

    public double Cost { get; set; }

    public int InStkQty { get; set; }

    public string ImagePath { get; set; } = null!;

    public virtual tblDirector Director { get; set; }

    public virtual tblFormat Format { get; set; }

    public virtual tblRating Rating { get; set; }

    public virtual ICollection<tblOrderItem> OrderItems { get; set; }

    public virtual ICollection<tblMovieGenre> MovieGenres { get; set; }
}
