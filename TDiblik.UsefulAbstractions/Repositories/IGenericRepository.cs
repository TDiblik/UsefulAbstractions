namespace TDiblik.UsefulAbstractions.Repositories
{
    /// <summary>
    /// <para>
    /// You should create interface, that describes your Repository and base it from this interface. (as seen in example)
    /// </para>
    /// <para>
    /// You should NEVER base repository on this interface
    /// </para>
    /// <example>
    /// Example implementation:
    /// <code>
    /// 
    /// public interface IWeatherRepository : IGenericRepository..WeatherForecastModel..int...
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
    ///             return await connection.QueryFirstOrDefaultAsync..WeatherForecastModel..("SELECT TOP(1) * FROM WeatherForcast WHERE ID = @ID", new {ID = id});
    ///         }
    ///     }
    ///
    ///     public async ... GetAllAsync()
    ///     {
    ///         using (var connection = _db.GetConnection()) {
    ///             return await connection.QueryAsync..WeatherForecastModel..("SELECT * FROM WeatherForcast");
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
    ///             return (await connection.QueryFirstOrDefaultAsync..WeatherForecastModel..("SELECT TOP(1) ID FROM WeatherForcast WHERE Date = @Date", new {Date = date})) != null;
    ///         }
    ///     }
    /// }
    /// 
    /// </code>
    /// </example>
    /// </summary>
    /// <typeparam name="T">Your model</typeparam>
    /// <typeparam name="I">Type of your ID, intended usage: string/int </typeparam>
    public interface IGenericRepository<T, I> 
        where T : class
        where I : notnull
    {
        public Task<IEnumerable<T>> GetAllAsync();

        public Task<T?> GetByIdAsync(I id);

        public Task<int> AddAsync(T entity);

        public Task<bool> UpdateAsync(T entity);

        public Task<bool> DeleteAsync(I id);
    }
}
