namespace BDF.DVDCentral.BL
{
    public abstract class GenericManager<T> where T : class, IEntity
    {
        protected DbContextOptions<DVDCentralEntities>? options;
        protected readonly ILogger? logger;

        public V Map<U, V>(U objFrom)
        {
            V objTo = (V)Activator.CreateInstance(typeof(V));
            var ToProperties = objTo.GetType().GetProperties();
            var FromProperties = objFrom.GetType().GetProperties();

            ToProperties
                .ToList()
                .ForEach(o =>
                {
                    var fromp = FromProperties.FirstOrDefault(x => x.Name == o.Name
                                                                && x.PropertyType == o.PropertyType);
                    if (fromp != null) {
                        o.SetValue(objTo, fromp.GetValue(objFrom));
                    } 
                });
            return objTo;
        }

        public async Task<T> LoadByIdAsync(Guid id)
        {
            try
            {
                return (await LoadAsync(e => e.Id == id)).FirstOrDefault()!;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<List<T>> LoadAsync(Expression<Func<T, bool>>? filter = null,
                                             Expression<Func<T, object>>[]? includeProperties = null)
        {
            try
            {
                if (filter == null)
                    filter = e => true;

                string info = $"Getting {typeof(T).Name}s - Generic Manager";

                IQueryable<T> rows = new DVDCentralEntities(options)
                    .Set<T>()
                    .Where(filter);

                logger?.LogWarning(info);

                info += rows.Count() + " records returned...";

                return rows.ToList();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }

    
}
