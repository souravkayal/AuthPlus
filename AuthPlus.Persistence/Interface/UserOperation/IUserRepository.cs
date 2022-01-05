using AuthPlus.Domain.Entity;
using AuthPlus.Persistence.DbFactory;

namespace AuthPlus.Persistence.Interface.UserOperation
{
    public interface IUserRepository 
    {
        Task<User> Get();
    }
}
