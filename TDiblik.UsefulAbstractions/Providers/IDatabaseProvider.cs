using System.Data;

namespace TDiblik.UsefulAbstractions.Providers
{
    /// <summary>
    /// <example>
    /// Example implementation:
    /// <code>
    ///
    /// public class DevDatabaseProvider : IDatabaseProvider
    /// {
    ///    private readonly string _connectionString;
    ///
    ///    public DevDatabaseProvider(IConfiguration configuration)
    ///    {
    ///        _connectionString = configuration.GetConnectionString("Dev");
    ///    }
    ///
    ///    public IDbConnection GetConnection()
    ///    {
    ///        IDbConnection db = new SqlConnection(_connectionString);
    ///        if (db.State == ConnectionState.Closed) {
    ///            db.Open();
    ///        }
    ///        return db;
    ///    }
    /// }
    ///
    /// </code>
    /// </example>
    /// </summary>
    public interface IDatabaseProvider
    {
        public IDbConnection GetConnection();
    }
}
