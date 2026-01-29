namespace BDF.DVDCentral.BL
{
    public class OrderItemManager : GenericManager<tblOrderItem>
    {
        public OrderItemManager(DbContextOptions<DVDCentralEntities> options, ILogger logger) : base(options, logger) { }

        public async Task<Guid> InsertAsync(OrderItem orderitem, bool rollback = false)
        {
            try
            {
                tblOrderItem row = Map<OrderItem, tblOrderItem>(orderitem);
                return await base.InsertAsync(row,
                                              null,
                                              rollback);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> UpdateAsync(OrderItem orderitem, bool rollback = false)
        {
            try
            {
                tblOrderItem row = Map<OrderItem, tblOrderItem>(orderitem);
                return await base.UpdateAsync(row,
                                              null,
                                              rollback);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<List<OrderItem>> LoadAsync()
        {
            try
            {
                List<OrderItem> rows = new List<OrderItem>();
                (await base.LoadAsync())
                    .ForEach(e => rows.Add(Map<tblOrderItem, OrderItem>(e)));
                return rows;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
