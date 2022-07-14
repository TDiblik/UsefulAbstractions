using System.Data;

namespace TDiblik.UsefulAbstractions.Providers
{
    public interface IDatabaseProvider
    {
        public IDbConnection GetConnection();
    }
}
