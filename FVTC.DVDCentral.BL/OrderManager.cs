using Microsoft.EntityFrameworkCore.Storage;
using FVTC.DVDCentral.BL.Models;
using FVTC.DVDCentral.PL;

namespace FVTC.DVDCentral.BL
{
    public static class OrderManager
    {
        public static int Insert(int customerId,
                                 DateTime orderDate,
                                 DateTime shipDate,
                                 int userId,
                                 ref int id,
                                 bool rollback = false)
        {
            try
            {
                Order order = new Order()
                {
                    CustomerId = customerId,
                    OrderDate = orderDate,
                    ShipDate = shipDate,
                    UserId = userId
                };

                int results = Insert(order, rollback);

                // IMPORTANT - BACKFILL THE REFERENCE ID
                id = order.Id;

                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Insert(Order order, bool rollback = false)
        {
            try
            {
                int results = 0;

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    tblOrder entity = new tblOrder();
                    entity.Id = dc.tblOrders.Any() ? dc.tblOrders.Max(o => o.Id) + 1 : 1; // set the id to the max + 1 or to 1 if there aren't any listed in the table
                    entity.CustomerId = order.CustomerId;
                    entity.OrderDate = order.OrderDate;
                    entity.ShipDate = order.ShipDate;
                    entity.UserId = order.UserId;
                    
                    foreach(OrderItem orderItem in order.OrderItems)
                    {
                        orderItem.OrderId = entity.Id;
                        results += OrderItemManager.Insert(orderItem, rollback);
                    }

                    // IMPORTANT - BACKFILL THE ID
                    order.Id = entity.Id;

                    dc.tblOrders.Add(entity);
                    results += dc.SaveChanges();

                    if (rollback) transaction.Rollback();
                }

                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Update(Order order, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    // Get the row that we are trying to update
                    tblOrder entity = dc.tblOrders.FirstOrDefault(o => o.Id == order.Id);

                    if (entity != null)
                    {
                        entity.CustomerId = order.CustomerId;
                        entity.OrderDate = order.OrderDate;
                        entity.ShipDate = order.ShipDate;
                        entity.UserId= order.UserId;
                        entity.Id = order.Id;
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
                    tblOrder entity = dc.tblOrders.FirstOrDefault(o => o.Id == id);

                    if (entity != null)
                    {
                        dc.tblOrders.Remove(entity);
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

        public static Order LoadById(int id)
        {
            try
            {
                return Load(null, id).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Order> Load(int? customerId = null, int? id = null)
        {
            try
            {
                List<Order> list = new List<Order>();

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    // similar to select * from tblOrders
                    (from o in dc.tblOrders
                     join c in dc.tblCustomers on o.CustomerId equals c.Id
                     join u in dc.tblUsers on o.UserId equals u.Id
                     where (o.CustomerId == customerId || customerId == null) || (o.Id == id || id == null)
                     select new
                     {
                         // creating a record set from the tblOrder fields
                         o.Id,
                         o.CustomerId,
                         CustomerFullName = c.FirstName + " " + c.LastName,
                         o.UserId,
                         o.OrderDate,
                         o.ShipDate,
                         UserFullName = u.FirstName + " " + u.LastName
                     })
                    .Distinct()
                    .ToList()
                    .ForEach(order => list.Add(new Order
                    {
                        Id = order.Id,
                        CustomerId = order.CustomerId,
                        CustomerFullName = order.CustomerFullName,
                        UserId = order.UserId,
                        OrderDate = order.OrderDate,
                        ShipDate = order.ShipDate,
                        UserFullName = order.UserFullName,
                        OrderItems = OrderItemManager.LoadByOrderId(order.Id)
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