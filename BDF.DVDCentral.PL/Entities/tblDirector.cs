namespace BDF.DVDCentral.PL.Entities;

public partial class tblDirector : IEntity
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual ICollection<tblMovie> Movies { get; set; } = new List<tblMovie>();
}
