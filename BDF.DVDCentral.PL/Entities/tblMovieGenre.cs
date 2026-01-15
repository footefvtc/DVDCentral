namespace BDF.DVDCentral.PL.Entities;

public partial class tblMovieGenre
{
    public Guid Id { get; set; }

    public Guid MovieId { get; set; }

    public Guid GenreId { get; set; }
}
