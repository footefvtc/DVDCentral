using Microsoft.EntityFrameworkCore.Storage;
using FVTC.DVDCentral.BL.Models;
using FVTC.DVDCentral.PL;

namespace FVTC.DVDCentral.BL
{
    public static class FormatManager
    {
        public static int Insert(string description,
                                 ref int id,
                                 bool rollback = false)
        {
            try
            {
                Format format = new Format()
                {
                    Description = description
                };

                int results = Insert(format, rollback);

                // IMPORTANT - BACKFIOLL THE REFERENCE ID
                id = format.Id;

                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Insert(Format format, bool rollback = false)
        {
            try
            {
                int results = 0;

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    tblFormat entity = new tblFormat();
                    entity.Id = dc.tblFormats.Any() ? dc.tblFormats.Max(f => f.Id) + 1 : 1; // set the id to the max + 1 or to 1 if there aren't any listed in the table
                    entity.Description = format.Description;

                    // IMPORTANT - BACK FILL THE ID
                    format.Id = entity.Id;

                    dc.tblFormats.Add(entity);
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

        public static int Update(Format format, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    // Get the row that we are trying to update
                    tblFormat entity = dc.tblFormats.FirstOrDefault(f => f.Id == format.Id);

                    if (entity != null)
                    {
                        entity.Description = format.Description;
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
                    tblFormat entity = dc.tblFormats.FirstOrDefault(f => f.Id == id);

                    if (entity != null)
                    {
                        dc.tblFormats.Remove(entity);
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

        public static Format LoadById(int id)
        {
            try
            {
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    tblFormat entity = dc.tblFormats.FirstOrDefault(f => f.Id == id);

                    if (entity != null)
                    {
                        return new Format
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

        public static List<Format> Load()
        {
            try
            {
                List<Format> list = new List<Format>();

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    // similar to select * from tblFormats
                    (from f in dc.tblFormats
                     select new
                     {
                         // creating a record set from the tblFormat fields
                         f.Id,
                         f.Description
                     })
                    .ToList()
                    .ForEach(format => list.Add(new Format
                    {
                        Id = format.Id,
                        Description = format.Description
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
