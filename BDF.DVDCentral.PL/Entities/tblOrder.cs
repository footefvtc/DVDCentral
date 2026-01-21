namespace BDF.DVDCentral.PL.Entities;

public partial class tblOrder
{
    public Guid Id { get; set; }

    public Guid CustomerId { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime ShipDate { get; set; }

    public Guid UserId { get; set; }

    public virtual ICollection<tblOrderItem> OrderItems { get; set; }

    public virtual tblCustomer Customer { get; set; }

    public virtual tblUser User { get; set; }
}
