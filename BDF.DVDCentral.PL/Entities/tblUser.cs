namespace BDF.DVDCentral.PL.Entities;

public partial class tblUser
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string Password { get; set; } = null!;
}
