namespace BDF.DVDCentral.PL.Entities;

public partial class tblGenre : IEntity
{
    public Guid Id { get; set; }

    public string Description { get; set; } = null!;
    public virtual ICollection<tblMovieGenre> MovieGenres { get; set;  }
}
