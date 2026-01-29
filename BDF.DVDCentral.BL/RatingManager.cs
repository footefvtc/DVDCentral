namespace BDF.DVDCentral.BL
{
    public class RatingManager : GenericManager<tblRating>
    {
        public RatingManager(DbContextOptions<DVDCentralEntities> options, ILogger logger) : base(options, logger) { }

        public async Task<Guid> InsertAsync(Rating rating, bool rollback = false)
        {
            try
            {
                tblRating row = Map<Rating, tblRating>(rating);
                return await base.InsertAsync(row,
                                              e => e.Description == rating.Description,
                                              rollback);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> UpdateAsync(Rating rating, bool rollback = false)
        {
            try
            {
                tblRating row = Map<Rating, tblRating>(rating);
                return await base.UpdateAsync(row,
                                              e => e.Description == rating.Description,
                                              rollback);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<List<Rating>> LoadAsync()
        {
            try
            {
                List<Rating> rows = new List<Rating>();
                (await base.LoadAsync())
                    .ForEach(e => rows.Add(Map<tblRating, Rating>(e)));
                return rows;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
