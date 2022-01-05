using AuthPlus.Domain.Entity;
using AuthPlus.Persistence.DbFactory;
using AuthPlus.Persistence.Interface.UserOperation;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace AuthPlus.Persistence.Implementation.UserOperation
{
    public class UserRepository : BaseRepository , IUserRepository
    {
        public UserRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public async Task<User> Get()
        {
            return await WithConnection(async conn =>
            {
                return await conn.QueryFirstOrDefaultAsync<User>("select TOP 1 * from [User]");
            });
        }

    }
}
