using Microsoft.EntityFrameworkCore.Storage;
using FVTC.DVDCentral.BL.Models;
using FVTC.DVDCentral.PL;
using System.Drawing.Printing;

namespace FVTC.DVDCentral.BL
{
    public static class OrderItemManager
    {
        public static int Insert(int orderId,
                                 int quantity,
                                 int movieId,
                                 float cost,
                                 ref int id,
                                 bool rollback = false)
        {
            try
            {
                OrderItem orderItem = new OrderItem()
                {
                    OrderId = orderId,
                    Quantity = quantity,
                    MovieId = movieId,
                    Cost = cost
                };

                int results = Insert(orderItem, rollback);

                // IMPORTANT - BACKFILL THE REFERENCE ID
                id = orderItem.Id;

                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Insert(OrderItem orderItem, bool rollback = false)
        {
            try
            {
                int results = 0;

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    tblOrderItem entity = new tblOrderItem();
                    entity.Id = dc.tblOrderItems.Any() ? dc.tblOrderItems.Max(oi => oi.Id) + 1 : 1; // set the id to the max + 1 or to 1 if there aren't any listed in the table
                    entity.OrderId = orderItem.OrderId;
                    entity.Quantity = orderItem.Quantity;
                    entity.MovieId = orderItem.MovieId;
                    entity.Cost = orderItem.Cost;

                    // IMPORTANT - BACK FILL THE ID
                    orderItem.Id = entity.Id;

                    dc.tblOrderItems.Add(entity);
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

        public static int Update(OrderItem orderItem, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    // Get the row that we are trying to update
                    tblOrderItem entity = dc.tblOrderItems.FirstOrDefault(oi => oi.Id == orderItem.Id);

                    if (entity != null)
                    {
                        entity.OrderId = orderItem.OrderId;
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
                    tblOrderItem entity = dc.tblOrderItems.FirstOrDefault(oi => oi.Id == id);

                    if (entity != null)
                    {
                        dc.tblOrderItems.Remove(entity);
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

        public static OrderItem LoadById(int id)
        {
            try
            {
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    var entity = (from oi in dc.tblOrderItems
                                  join m in dc.tblMovies on oi.MovieId equals m.Id
                                  where oi.Id == id
                                  select new
                                  {
                                      oi.Id,
                                      oi.OrderId,
                                      m.ImagePath,
                                      oi.Quantity,
                                      oi.MovieId,
                                      m.Title,
                                      oi.Cost
                                  }).FirstOrDefault();

                    if (entity != null)
                    {
                        return new OrderItem
                        {
                            Id = entity.Id,
                            OrderId = entity.OrderId,
                            ImagePath = entity.ImagePath,
                            Quantity = entity.Quantity,
                            MovieId = entity.MovieId,
                            Title = entity.Title,
                            Cost = (float)entity.Cost
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


        public static List<OrderItem> LoadByOrderId(int orderId)
        {
            try
            {
                List<OrderItem> list = new List<OrderItem>();

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    // similar to select * from tblOrderItems
                    (from oi in dc.tblOrderItems
                     join m in dc.tblMovies on oi.MovieId equals m.Id
                     where oi.OrderId == orderId
                     select new
                     {
                         // creating a record set from the tblOrderItem fields
                         oi.Id,
                         oi.OrderId,
                         m.ImagePath,
                         oi.Quantity,
                         oi.MovieId,
                         m.Title,
                         oi.Cost
                     })
                    .ToList()
                    .ForEach(orderItem => list.Add(new OrderItem
                    {
                        Id = orderItem.Id,
                        OrderId = orderItem.OrderId,
                        ImagePath = orderItem.ImagePath,
                        Quantity = orderItem.Quantity,
                        MovieId = orderItem.MovieId,
                        Title = orderItem.Title,
                        Cost = (float)orderItem.Cost
                    }));
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<OrderItem> Load(int? Id = null)
        {
            try
            {
                List<OrderItem> list = new List<OrderItem>();

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    // similar to select * from tblOrderItems
                    (from oi in dc.tblOrderItems
                     join m in dc.tblMovies on oi.MovieId equals m.Id
                     where oi.Id == Id || Id == null
                     select new
                     {
                         // creating a record set from the tblOrderItem fields
                         oi.Id,
                         oi.OrderId,
                         m.ImagePath,
                         oi.Quantity,
                         oi.MovieId,
                         m.Title,
                         oi.Cost
                     })
                    .ToList()
                    .ForEach(orderItem => list.Add(new OrderItem
                    {
                        Id = orderItem.Id,
                        OrderId = orderItem.OrderId,
                        ImagePath = orderItem.ImagePath,
                        Quantity = orderItem.Quantity,
                        MovieId = orderItem.MovieId,
                        Title = orderItem.Title,
                        Cost = (float)orderItem.Cost
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
