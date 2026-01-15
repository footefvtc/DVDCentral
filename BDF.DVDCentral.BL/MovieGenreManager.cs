using Microsoft.EntityFrameworkCore.Storage;
using BDF.DVDCentral.BL.Models;
using BDF.DVDCentral.PL;

namespace BDF.DVDCentral.BL
{
    public static class MovieGenreManager
    {
        public static int Insert(int movieId,
                                 int genreId,
                                 ref int id,
                                 bool rollback = false)
        {
            try
            {
                MovieGenre movieGenre = new MovieGenre()
                {
                    MovieId = movieId,
                    GenreId = genreId
                };

                int results = Insert(movieGenre, rollback);

                // IMPORTANT - BACKFILL THE REFERENCE ID
                id = movieGenre.Id;

                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Insert(int movieId, int genreId, bool rollback = false)
        {
            try
            {
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    tblMovieGenre tblMovieGenre = new tblMovieGenre();
                    tblMovieGenre.MovieId = movieId;
                    tblMovieGenre.GenreId = genreId;
                    tblMovieGenre.Id = dc.tblMovieGenres.Any() ? dc.tblMovieGenres.Max(mg => mg.Id) + 1 : 1;

                    dc.tblMovieGenres.Add(tblMovieGenre);
                    dc.SaveChanges();

                    if (rollback) transaction.Rollback();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Insert(MovieGenre movieGenre, bool rollback = false)
        {
            try
            {
                int results = 0;

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    tblMovieGenre entity = new tblMovieGenre();
                    entity.Id = dc.tblMovieGenres.Any() ? dc.tblMovieGenres.Max(mg => mg.Id) + 1 : 1; // set the id to the max + 1 or to 1 if there aren't any listed in the table
                    entity.MovieId = movieGenre.MovieId;

                    // IMPORTANT - BACKFILL THE ID
                    movieGenre.Id = entity.Id;

                    dc.tblMovieGenres.Add(entity);
                    results = dc.SaveChanges();

                    if (rollback) transaction.Rollback();
                }

                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static int Update(MovieGenre movieGenre, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    // Get the row that we are trying to update
                    tblMovieGenre entity = dc.tblMovieGenres.FirstOrDefault(mg => mg.Id == movieGenre.Id);

                    if (entity != null)
                    {
                        entity.MovieId = movieGenre.MovieId;
                        results = dc.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Row does not exist.");
                    }

                    if (rollback) transaction.Rollback();
                }

                return results;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Delete(int id, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    // Get the row that we are trying to update
                    tblMovieGenre entity = dc.tblMovieGenres.FirstOrDefault(mg => mg.Id == id);

                    if (entity != null)
                    {
                        dc.tblMovieGenres.Remove(entity);
                        results = dc.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Row does not exist.");
                    }

                    if (rollback) transaction.Rollback();
                }

                return results;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(int movieId, int genreId, bool rollback = false)
        {
            try
            {
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    tblMovieGenre? tblMovieGenre = dc.tblMovieGenres.FirstOrDefault(mg => mg.MovieId == movieId
                                                   && mg.GenreId == genreId);
                    if (tblMovieGenre != null)
                    {
                        dc.tblMovieGenres.Remove(tblMovieGenre);
                        dc.SaveChanges();
                    }

                    if (rollback) transaction.Rollback();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static MovieGenre LoadById(int id)
        {
            try
            {
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    tblMovieGenre entity = dc.tblMovieGenres.FirstOrDefault(mg => mg.Id == id);

                    if (entity != null)
                    {
                        return new MovieGenre
                        {
                            Id = entity.Id,
                            MovieId = entity.MovieId,
                            GenreId = entity.GenreId
                        };
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
