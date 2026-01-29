namespace BDF.DVDCentral.BL
{
    public class DirectorManager : GenericManager<tblDirector>
    {
        public DirectorManager(DbContextOptions<DVDCentralEntities> options, ILogger logger) : base(options, logger) { }

        public async Task<Guid> InsertAsync(Director director, bool rollback = false)
        {
            try
            {
                tblDirector row = Map<Director, tblDirector>(director);
                return await base.InsertAsync(row,
                                              e => e.LastName == director.LastName
                                              && e.FirstName == director.FirstName,
                                              rollback);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> UpdateAsync(Director director, bool rollback = false)
        {
            try
            {
                tblDirector row = Map<Director, tblDirector>(director);
                return await base.UpdateAsync(row,
                                              e => e.LastName == director.LastName
                                              && e.FirstName == director.FirstName,
                                              rollback);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<List<Director>> LoadAsync()
        {
            try
            {
                List<Director> rows = new List<Director>();
                (await base.LoadAsync())
                    .ForEach(e => rows.Add(Map<tblDirector, Director>(e)));
                return rows;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
