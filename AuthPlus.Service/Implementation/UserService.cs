using AuthPlus.Domain.Entity;
using AuthPlus.Persistence.Interface.UserOperation;
using AuthPlus.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthPlus.Service.Implementation
{
    public class UserService : IUserService
    {
        readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public Task<User> Get()
        {
            return _userRepository.Get();
        }
    }
}
