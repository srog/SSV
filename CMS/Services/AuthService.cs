using System;
using CMS.Models;

namespace CMS.Services
{
    public class AuthService : IAuthService
    {
        public int CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public int DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsAdminUser()
        {
            return true;
        }

        public bool IsAuthenticated()
        {
            return true;
        }

        public int Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public int Logout()
        {
            throw new NotImplementedException();
        }

        public int UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
