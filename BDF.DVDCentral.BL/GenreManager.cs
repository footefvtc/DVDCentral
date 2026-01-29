namespace BDF.DVDCentral.BL
{
    public class GenreManager : GenericManager<tblGenre>
    {
        public GenreManager(DbContextOptions<DVDCentralEntities> options, ILogger logger) : base(options, logger) { }

        public async Task<Guid> InsertAsync(Genre genre, bool rollback = false)
        {
            try
            {
                tblGenre row = Map<Genre, tblGenre>(genre);
                return await base.InsertAsync(row,
                                              e => e.Description == genre.Description,
                                              rollback);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> UpdateAsync(Genre genre, bool rollback = false)
        {
            try
            {
                tblGenre row = Map<Genre, tblGenre>(genre);
                return await base.UpdateAsync(row,
                                              e => e.Description == genre.Description,
                                              rollback);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<List<Genre>> LoadAsync()
        {
            try
            {
                List<Genre> rows = new List<Genre>();
                (await base.LoadAsync())
                    .ForEach(e => rows.Add(Map<tblGenre, Genre>(e)));
                return rows;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
