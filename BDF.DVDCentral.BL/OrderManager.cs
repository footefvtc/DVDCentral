namespace BDF.DVDCentral.BL
{
    public class OrderManager : GenericManager<tblOrder>
    {
        public OrderManager(DbContextOptions<DVDCentralEntities> options, ILogger logger) : base(options, logger) { }

        public async Task<Guid> InsertAsync(Order order, bool rollback = false)
        {
            try
            {
                tblOrder row = Map<Order, tblOrder>(order);
                return await base.InsertAsync(row,
                                              null,
                                              rollback);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> UpdateAsync(Order order, bool rollback = false)
        {
            try
            {
                tblOrder row = Map<Order, tblOrder>(order);
                return await base.UpdateAsync(row,
                                              null,
                                              rollback);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<OrderItem> ConvertOrderItems(ICollection<tblOrderItem> tblOrderItems)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            tblOrderItems
                .ToList()
                .ForEach(item => orderItems
                .Add(Map<tblOrderItem, OrderItem>(item)));
            return orderItems;
        }

        public async Task<List<Order>> LoadAsync(Guid? customerId = null)
        {
            try
            {
                List<Order> rows = new List<Order>();

                Expression<Func<tblOrder, object>>[] includeProperties = new Expression<Func<tblOrder, object>>[3];
                includeProperties[0] = x => x.Customer;
                includeProperties[1] = x => x.OrderItems;
                includeProperties[2] = x => x.User;

                Expression<Func<tblOrder, bool>> filter = null;

                if (customerId != null)
                    filter = o => o.CustomerId == customerId;

                (await base.LoadAsync(filter, includeProperties))
                    .ForEach(o =>
                    {
                        Order order = Map<tblOrder, Order>(o);
                        order.UserFullName = $"{o.User.LastName}, {o.User.FirstName}";
                        order.CustomerFullName = $"{o.Customer.LastName}, {o.Customer.FirstName}";
                        order.OrderItems = ConvertOrderItems(o.OrderItems);
                        rows.Add(order);
                    });

                return rows;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Order> LoadByIdAsync(Guid id)
        {
            try
            {
                Expression<Func<tblOrder, object>>[] includeProperties = new Expression<Func<tblOrder, object>>[3];
                includeProperties[0] = x => x.Customer;
                includeProperties[1] = x => x.OrderItems;
                includeProperties[2] = x => x.User;

                List<tblOrder> rows = await base.LoadAsync(e => e.Id == id, includeProperties);
                if (rows[0] != null)
                {
                    Order order = Map<tblOrder, Order>(rows[0]);
                    order.UserFullName = $"{rows[0].User.LastName}, {rows[0].User.FirstName}";
                    order.CustomerFullName = $"{rows[0].Customer.LastName}, {rows[0].Customer.FirstName}";
                    order.OrderItems = ConvertOrderItems(rows[0].OrderItems);
                    return order;
                }
                else
                    throw new Exception("No row");

            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> DeleteAsync(Guid id, bool rollback = false)
        {
            try
            {
                int results = 0;

                using (DVDCentralEntities dc = new DVDCentralEntities(options))
                {
                    IDbContextTransaction? transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    tblOrder deleteRow = dc.tblOrders.FirstOrDefault(r => r.Id == id)!;

                    if (deleteRow != null)
                    {
                        dc.tblOrders.Remove(deleteRow);

                        var deleteOrderItems = dc.tblOrderItems.Where(r => r.OrderId == id);

                        dc.tblOrderItems.RemoveRange(deleteOrderItems);

                        // Commit the changes and get the number of rows affected
                        results = dc.SaveChanges();

                        if (rollback) transaction?.Rollback();
                    }
                    else
                    {
                        throw new Exception("Row was not found.");
                    }
                }
                return results;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
