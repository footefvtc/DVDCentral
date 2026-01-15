using Microsoft.EntityFrameworkCore.Storage;
using BDF.DVDCentral.BL.Models;
using BDF.DVDCentral.PL;

namespace BDF.DVDCentral.BL
{
    public class CreateFailureException : Exception
    {
        public CreateFailureException() : base("Please enter 2 letters for the state.")
        {
        }

        public CreateFailureException(string message) : base(message)
        {
        }
    }

    public static class CustomerManager
    {
        public static int Insert(string firstName,
                                 string lastName,
                                 int userId,
                                 string address,
                                 string city,
                                 string state,
                                 string Zip,
                                 string phone,
                                 ref int id,
                                 bool rollback = false)
        {
            try
            {
                if (state.Length == 2)
                {
                    Customer customer = new Customer()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        UserId = userId,
                        Address = address,
                        City = city,
                        State = state,
                        Zip = Zip,
                        Phone = phone
                    };

                    int results = Insert(customer, rollback);

                    // IMPORTANT - BACKFILL THE REFERENCE ID
                    id = customer.Id;

                    return results;
                }
                else
                {
                    throw new CreateFailureException();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Insert(Customer customer, bool rollback = false)
        {
            try
            {
                int results = 0;

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction transaction = null!;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    if (customer.State.Length == 2)
                    {
                        tblCustomer entity = new tblCustomer();
                        entity.Id = dc.tblCustomers.Any() ? dc.tblCustomers.Max(c => c.Id) + 1 : 1; // set the id to the max + 1 or to 1 if there aren't any listed in the table
                        entity.FirstName = customer.FirstName;
                        entity.LastName = customer.LastName;
                        entity.UserId = customer.UserId;
                        entity.Address = customer.Address;
                        entity.City = customer.City;
                        entity.State = customer.State;
                        entity.Zip = customer.Zip;
                        entity.Phone = customer.Phone;

                        // IMPORTANT - BACKFILL THE ID
                        customer.Id = entity.Id;

                        dc.tblCustomers.Add(entity);
                        results = dc.SaveChanges();
                    }
                    else
                    {
                        throw new CreateFailureException();
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

        public static int Update(Customer customer, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction transaction = null!;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    // Get the row that we are trying to update
                    tblCustomer entity = dc.tblCustomers.FirstOrDefault(c => c.Id == customer.Id)!;

                    if (entity != null)
                    {
                        entity.FirstName = customer.FirstName;
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
                    IDbContextTransaction transaction = null!;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    // Get the row that we are trying to update
                    tblCustomer entity = dc.tblCustomers.FirstOrDefault(c => c.Id == id)!;

                    if (entity != null)
                    {
                        dc.tblCustomers.Remove(entity);
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

        public static Customer LoadById(int id)
        {
            try
            {
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    tblCustomer entity = dc.tblCustomers.FirstOrDefault(c => c.Id == id)!;   

                    if (entity != null)
                    {
                        return new Customer
                        {
                            Id = entity.Id,
                            FirstName = entity.FirstName,
                            LastName = entity.LastName,
                            UserId = entity.UserId,
                            Address = entity.Address,
                            City = entity.City,
                            State = entity.State,
                            Zip = entity.Zip,
                            Phone = entity.Phone
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

        public static List<Customer> Load()
        {
            try
            {
                List<Customer> list = new List<Customer>();

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    // similar to select * from tblCustomers
                    (from c in dc.tblCustomers
                     select new
                     {
                         // creating a record set from the tblCustomer fields
                         c.Id,
                         c.FirstName,
                         c.LastName,
                         c.UserId,
                         c.Address,
                         c.City,
                         c.State,
                         c.Zip,
                         c.Phone
                     })
                    .ToList()
                    .ForEach(customer => list.Add(new Customer
                    {
                        Id = customer.Id,
                        FirstName = customer.FirstName,
                        LastName = customer.LastName,
                        UserId = customer.UserId,
                        Address = customer.Address,
                        City = customer.City,
                        State = customer.State,
                        Zip = customer.Zip,
                        Phone = customer.Phone
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
