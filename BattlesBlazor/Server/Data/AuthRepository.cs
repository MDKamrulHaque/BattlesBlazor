using BattlesBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattlesBlazor.Server.Data
{
    public class AuthRepository : IAuthRepository
    {
        public Task<string> Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<int> Register(User user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExists(string email)
        {
            throw new NotImplementedException();
        }
    }
}
