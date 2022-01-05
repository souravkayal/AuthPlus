using AuthPlus.Domain.Common;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthPlus.Persistence.DbFactory
{
    public class GoUrlConnectionFactory : IDbFactory
    {
        private IDbConnection _connection;
        private readonly IOptions<AppConfig> _configs;

        public GoUrlConnectionFactory(IOptions<AppConfig> Configs)
        {
            _configs = Configs;
        }

        public IDbConnection GetConnection
        {
            get
            {
                //if (_connection == null)
                {
                    _connection = new SqlConnection(_configs.Value.DbConnectionString);
                }
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                return _connection;
            }
        }

        public void CloseConnection()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }

    }
}
