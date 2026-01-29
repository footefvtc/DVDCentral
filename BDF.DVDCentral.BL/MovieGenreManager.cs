namespace BDF.DVDCentral.BL
{
    public class MovieGenreManager : GenericManager<tblMovieGenre>
    {
        public MovieGenreManager(DbContextOptions<DVDCentralEntities> options, ILogger logger) : base(options, logger) { }

        public async Task<Guid> InsertAsync(MovieGenre moviegenre, bool rollback = false)
        {
            try
            {
                tblMovieGenre row = Map<MovieGenre, tblMovieGenre>(moviegenre);
                return await base.InsertAsync(row,
                                              null,
                                              rollback);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> UpdateAsync(MovieGenre moviegenre, bool rollback = false)
        {
            try
            {
                tblMovieGenre row = Map<MovieGenre, tblMovieGenre>(moviegenre);
                return await base.UpdateAsync(row,
                                              null,
                                              rollback);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<List<MovieGenre>> LoadAsync()
        {
            try
            {
                List<MovieGenre> rows = new List<MovieGenre>();
                (await base.LoadAsync())
                    .ForEach(e => rows.Add(Map<tblMovieGenre, MovieGenre>(e)));
                return rows;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
