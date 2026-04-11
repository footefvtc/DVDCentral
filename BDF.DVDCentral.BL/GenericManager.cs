namespace BDF.DVDCentral.BL
{
    public abstract class GenericManager<T> where T : class, IEntity
    {
        protected DbContextOptions<DVDCentralEntities> options;
        protected readonly ILogger? logger;

        public GenericManager(DbContextOptions<DVDCentralEntities> options)
        {
            this.options = options;
        }

        public GenericManager(DbContextOptions<DVDCentralEntities> options, ILogger logger)
        {
            this.options = options;
            this.logger = logger;
        }

        public static string[,] ConvertData<U>(List<U> entities, string[] columns)
        {
            try
            {
                // Convert a list to a 2d array
                string[,] data = new string[entities.Count + 1, columns.Length];
                int counter = 0;

                for (int i = 0; i < columns.Length; i++)
                {
                    data[counter, i] = columns[i];
                }
                counter++;

                foreach (var entity in entities)
                {
                    for (int i = 0; i < columns.Length; i++)
                    {
                        data[counter, i] = entity?.GetType()
                                            ?.GetProperty(columns[i])
                                            ?.GetValue(entity, null)
                                            ?.ToString() ?? string.Empty;
                    }
                    counter++;
                }
                return data;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public V Map<U, V>(U objfrom)
        {
            V objTo = (V)Activator.CreateInstance(typeof(V));

            var ToProperties = objTo.GetType().GetProperties();
            var FromProperties = objfrom.GetType().GetProperties();

            ToProperties
                .ToList()
                .ForEach(o =>
                {
                    var fromp = FromProperties.FirstOrDefault(x => x.Name == o.Name
                                                          && x.PropertyType == o.PropertyType);
                    if (fromp != null)
                    {
                        o.SetValue(objTo, fromp.GetValue(objfrom));
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

        public async Task<List<V>> LoadAsync<V>(string storedproc) where V : class
        {
            try
            {
                return new DVDCentralEntities(options)
                    .Set<V>()
                    .FromSqlRaw($"exec {storedproc}")
                    .ToList<V>();
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
                // if no filter, return all
                if (filter == null)
                    filter = e => true;

                string info = $"Get {typeof(T).Name}s - GenericManager: ";

                IQueryable<T> rows = new DVDCentralEntities(options)
                    .Set<T>()
                    .Where(filter);

                if (includeProperties != null)
                {
                    foreach (var prop in includeProperties)
                    {
                        rows = rows.Include<T, object>(prop);
                    }
                }

                info += rows.Count() + " records returned...";
                logger?.LogWarning(info + "{UserId}", "bfoote");
                return rows.ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> DeleteAsync(Guid id,
                                           bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities(options))
                {
                    IDbContextTransaction? transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    T row = dc.Set<T>().FirstOrDefault(t => t.Id == id)!;

                    if (row != null)
                    {
                        dc.Set<T>().Remove(row);
                        results = dc.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Row does not exist.");
                    }

                    if (rollback) transaction?.Rollback();

                }

                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> UpdateAsync(T entity,
                                         Expression<Func<T, bool>>? expression = null,
                                         bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities(options))
                {

                    if ((expression == null) || ((expression != null) &&
                        (!dc.Set<T>().Any(expression))))
                    {

                        IDbContextTransaction? transaction = null;
                        if (rollback) transaction = dc.Database.BeginTransaction();

                        dc.Entry(entity).State = EntityState.Modified;

                        results = dc.SaveChanges();
                        if (rollback) transaction?.Rollback();
                    }
                    else
                    {
                        // log the error
                    }
                }

                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Guid> InsertAsync(T entity,
                                            Expression<Func<T, bool>>? expression = null,
                                            bool rollback = false)
        {
            try
            {
                using (DVDCentralEntities dc = new DVDCentralEntities(options))
                {

                    if ((expression == null) || ((expression != null) &&
                        (!dc.Set<T>().Any(expression))))
                    {

                        IDbContextTransaction transaction = null;
                        if (rollback) transaction = dc.Database.BeginTransaction();
                        entity.Id = Guid.NewGuid();
                        dc.Set<T>().Add(entity);
                        dc.SaveChanges();
                        if (rollback) transaction?.Rollback();
                    }
                    else
                    {
                        // log the error
                    }
                }

                return entity.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
