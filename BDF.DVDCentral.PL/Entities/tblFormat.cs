namespace BDF.DVDCentral.PL.Entities;

public partial class tblFormat : IEntity
{
    public Guid Id { get; set; }

    public string Description { get; set; } = null!;
    public virtual ICollection<tblMovie> Movies { get; set; } = new List<tblMovie>();
}
