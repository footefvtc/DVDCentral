namespace BDF.DVDCentral.PL.Entities;

public partial class tblMovieGenre
{
    public Guid Id { get; set; }

    public Guid MovieId { get; set; }

    public Guid GenreId { get; set; }

    public virtual tblGenre Genre { get; set; } 
    public virtual tblMovie Movie { get; set; }
}
