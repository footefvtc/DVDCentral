namespace BDF.DVDCentral.BL
{
    public class FormatManager : GenericManager<tblFormat>
    {
        public FormatManager(DbContextOptions<DVDCentralEntities> options, ILogger logger) : base(options, logger) { }

        public async Task<Guid> InsertAsync(Format format, bool rollback = false)
        {
            try
            {
                tblFormat row = Map<Format, tblFormat>(format);
                return await base.InsertAsync(row,
                                              e => e.Description == format.Description,
                                              rollback);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> UpdateAsync(Format format, bool rollback = false)
        {
            try
            {
                tblFormat row = Map<Format, tblFormat>(format);
                return await base.UpdateAsync(row,
                                              e => e.Description == format.Description,
                                              rollback);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<List<Format>> LoadAsync()
        {
            try
            {
                List<Format> rows = new List<Format>();
                (await base.LoadAsync())
                    .ForEach(e => rows.Add(Map<tblFormat, Format>(e)));
                return rows;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
