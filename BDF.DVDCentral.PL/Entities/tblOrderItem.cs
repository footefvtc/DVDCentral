namespace BDF.DVDCentral.PL.Entities;

public partial class tblOrderItem
{
    public Guid Id { get; set; }

    public Guid OrderId { get; set; }

    public int Quantity { get; set; }

    public Guid MovieId { get; set; }

    public double Cost { get; set; }

    public virtual tblMovie Movie { get; set; }

    public virtual tblOrder Order { get; set; }
}
