namespace BDF.DVDCentral.PL.Entities
{

    public class spGetMoviesResult : IEntity
    {
        public Guid Id { get; set; }
        public Guid FormatId { get; set; }

        public Guid DirectorId { get; set; }

        public Guid RatingId { get; set; }

        public double Cost { get; set; }

        public int InStkQty { get; set; }

        public string? Title { get; set; }
        public string? RatingDescription { get; set; }
        public string? FormatDescription { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string SortField { get { return Title; } }
    }


}
