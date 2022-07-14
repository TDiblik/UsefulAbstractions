namespace TDiblik.UsefulAbstractions.Repositories
{
    /// <summary>
    /// <example>
    /// Example implementation:
    /// <code>
    /// 
    /// public interface IWeatherRepository : IGenericRepository..T..
    /// {
    ///     public ... ExistsAsync(DateTime date);
    /// }
    ///
    /// public class WeatherRepository : IWeatherRepository
    /// {
    ///     private readonly IDatabaseProvider _db;
    ///
    ///     public WeatherRepository(IDatabaseProvider db)
    ///     {
    ///         _db = db;
    ///     }
    ///
    ///     public async ... GetByIdAsync(int id)
    ///     {
    ///         using (var connection = _db.GetConnection()) {
    ///             return await connection.QueryFirstOrDefaultAsync..T..("SELECT TOP(1) * FROM WeatherForcast WHERE ID = @ID", new {ID = id});
    ///         }
    ///     }
    ///
    ///     public async ... GetAllAsync()
    ///     {
    ///         using (var connection = _db.GetConnection()) {
    ///             return await connection.QueryAsync..T..("SELECT * FROM WeatherForcast");
    ///         }
    ///     }
    ///
    ///     public async ... AddAsync(WeatherForecastModel entity)
    ///     {
    ///         using (var connection = _db.GetConnection()) {
    ///             return await connection.InsertAsync(entity);
    ///         }
    ///     }
    ///
    ///     public async ... UpdateAsync(WeatherForecastModel entity)
    ///     {
    ///         using (var connection = _db.GetConnection()) {
    ///             return await connection.UpdateAsync(entity);
    ///         }
    ///     }
    ///
    ///     public async ... DeleteAsync(int id)
    ///     {
    ///         using (var connection = _db.GetConnection()) {
    ///             return await connection.ExecuteAsync("DELETE FROM WeatherForcast WHERE ID = @ID", new {ID = id}) > 0;
    ///         }
    ///     }
    ///
    ///     public async ... ExistsAsync(DateTime date)
    ///     {
    ///         using (var connection = _db.GetConnection()) {
    ///             return (await connection.QueryFirstOrDefaultAsync..T..("SELECT TOP(1) ID FROM WeatherForcast WHERE Date = @Date", new {Date = date})) != null;
    ///         }
    ///     }
    /// }
    /// 
    /// </code>
    /// </example>
    /// </summary>
    public interface IGenericRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync();

        public Task<T?> GetByIdAsync(int id);

        public Task<int> AddAsync(T entity);

        public Task<bool> UpdateAsync(T entity);

        public Task<bool> DeleteAsync(int id);
    }
}
