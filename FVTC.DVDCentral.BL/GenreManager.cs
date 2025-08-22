using Microsoft.EntityFrameworkCore.Storage;
using FVTC.DVDCentral.BL.Models;
using FVTC.DVDCentral.PL;

namespace FVTC.DVDCentral.BL
{
    public static class GenreManager
    {
        public static int Insert(string description,
                                 ref int id,
                                 bool rollback = false)
        {
            try
            {
                Genre genre = new Genre()
                {
                    Description = description
                };

                int results = Insert(genre, rollback);

                // IMPORTANT - BACKFILL THE REFERENCE ID
                id = genre.Id;

                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Insert(Genre genre, bool rollback = false)
        {
            try
            {
                int results = 0;

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    tblGenre entity = new tblGenre();
                    entity.Id = dc.tblGenres.Any() ? dc.tblGenres.Max(g => g.Id) + 1 : 1; // set the id to the max + 1 or to 1 if there aren't any listed in the table
                    entity.Description = genre.Description;

                    // IMPORTANT - BACKFILL THE ID
                    genre.Id = entity.Id;

                    dc.tblGenres.Add(entity);
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

        public static int Update(Genre genre, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    // Get the row that we are trying to update
                    tblGenre entity = dc.tblGenres.FirstOrDefault(g => g.Id == genre.Id);

                    if (entity != null)
                    {
                        entity.Description = genre.Description;
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
                    tblGenre entity = dc.tblGenres.FirstOrDefault(g => g.Id == id);

                    if (entity != null)
                    {
                        dc.tblGenres.Remove(entity);
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

        public static Genre LoadById(int id)
        {
            try
            {
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    tblGenre entity = dc.tblGenres.FirstOrDefault(g => g.Id == id);

                    if (entity != null)
                    {
                        return new Genre
                        {
                            Id = entity.Id,
                            Description = entity.Description
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

        public static List<Genre> Load(int? id = null)
        {
            try
            {
                List<Genre> list = new List<Genre>();

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    // similar to select * from tblGenres
                    (from g in dc.tblGenres
                     where g.Id == id || id == null
                     select new
                     {
                         // creating a record set from the tblGenre fields
                         g.Id,
                         g.Description
                     })
                    .ToList()
                    .ForEach(genre => list.Add(new Genre
                    {
                        Id = genre.Id,
                        Description = genre.Description
                    }));
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Genre> LoadByMovieId(int? movieId = null)
        {
            try
            {
                List<Genre> list = new List<Genre>();

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    // similar to select * from tblGenres
                    (from g in dc.tblGenres
                     join mg in dc.tblMovieGenres on g.Id equals mg.GenreId
                     where mg.MovieId == movieId || movieId == null
                     select new
                     {
                         // creating a record set from the tblGenre fields
                         g.Id,
                         g.Description
                     })
                    .ToList()
                    .ForEach(genre => list.Add(new Genre
                    {
                        Id = genre.Id,
                        Description = genre.Description
                    }));
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
