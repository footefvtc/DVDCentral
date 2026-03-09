namespace BDF.DVDCentral.BL
{
    public class CustomerManager : GenericManager<tblCustomer>
    {
        public CustomerManager(DbContextOptions<DVDCentralEntities> options, ILogger logger) : base(options, logger) { }

        public async Task<Guid> InsertAsync(Customer customer, bool rollback = false)
        {
            try
            {
                tblCustomer row = Map<Customer, tblCustomer>(customer);
                return await base.InsertAsync(row,
                                              null,
                                              rollback);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> UpdateAsync(Customer customer, bool rollback = false)
        {
            try
            {
                tblCustomer row = Map<Customer, tblCustomer>(customer);
                return await base.UpdateAsync(row,
                                              null,
                                              rollback);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Customer>> LoadAsync()
        {
            try
            {
                List<Customer> rows = new List<Customer>();
                (await base.LoadAsync())
                    .ForEach(e => rows.Add(Map<tblCustomer, Customer>(e)));
                return rows;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
