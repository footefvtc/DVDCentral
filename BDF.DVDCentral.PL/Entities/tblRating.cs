namespace BDF.DVDCentral.PL.Entities;

public partial class tblRating
{
    public Guid Id { get; set; }

    public string Description { get; set; } = null!;
    public virtual ICollection<tblMovie> Movies { get; set; }
}
