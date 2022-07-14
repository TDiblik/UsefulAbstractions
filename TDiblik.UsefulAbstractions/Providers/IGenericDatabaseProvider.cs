using System.Data;

namespace TDiblik.UsefulAbstractions.Providers
{
    /// <summary>
    /// <para>
    /// You should create interface, that describes your DatabaseProvider and base it from this interface. (as seen in example)
    /// </para>
    /// <para>
    /// You should NEVER base DatabaseProvider (DevDatabaseProvider in this example) on this interface
    /// </para>
    /// <example>
    /// Example implementation:
    /// <code>
    /// public interface IDatabaseProvider : IGenericDatabaseProvider 
    /// {
    /// }
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
    public interface IGenericDatabaseProvider
    {
        public IDbConnection GetConnection();
    }
}
