using System.Data;

namespace AuthPlus.Persistence.DbFactory
{
    internal interface IDbFactory
    {
        IDbConnection GetConnection { get; }
        void CloseConnection();
    }
}
