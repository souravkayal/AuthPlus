using AuthPlus.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthPlus.Service.Interface
{
    public interface IUserService
    {
        Task<User> Get();
    }
}
