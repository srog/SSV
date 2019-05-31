using System.Collections.Generic;
using System.Data;
using System.Linq;
using CMS.DataAccess;
using CMS.Models;
using CMS.Models.Enums;
using Dapper;

namespace CMS.Services
{
    public interface IAuthService
    {
        string GetCurrentUsername();
        User GetCurrentUser();
        IEnumerable<User> GetAllUsers();
        User GetUser(int id);

        bool IsAuthenticated();
        bool IsAdminUser();
        int Login(string username, string password);
        void Logout();
        int CreateUser(User user);
        int UpdateUser(User user);
        int DeleteUser(int id);
        int ActivateUser(int id);
    }
    public class AuthService : IAuthService
    {
        private static int _loggedInUserId;

        private const string GET_USER = "spGetUser";
        private const string GET_ALL_USERS = "spGetAllUsers";
        private const string INSERT_USER = "spInsertUser";
        private const string UPDATE_USER = "spUpdateUser";

        private readonly IDataAccessor _dataAccessor;
        public AuthService(IDataAccessor dataAccessor)
        {
            _dataAccessor = dataAccessor;
        }

        public User Guest()
        {
            return new User {FullName = "Guest", Id = 0, UserType = UserTypeEnum.Guest, Username = "Guest"};
        }

        public User GetCurrentUser()
        {
            //var loggedInUserId = _loggedInUserId; // session / appsession / cookie
            return _loggedInUserId == 0 ? Guest() : GetUser(_loggedInUserId);
        }

        public string GetCurrentUsername()
        {
            return GetCurrentUser().Username;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _dataAccessor.Query<User>(GET_ALL_USERS);
        }

        public User GetUser(int id)
        {
            var user =  _dataAccessor.QuerySingle<User>(GET_USER, new { id } );
            return user ?? Guest();
        }

        public int CreateUser(User user)
        {
            var allParam = new DynamicParameters();
            allParam.Add("id", dbType: DbType.Int32, direction: ParameterDirection.Output);
            allParam.Add("username", user.Username);
            allParam.Add("password", user.Password);
            allParam.Add("fullName", user.FullName);
            allParam.Add("isActive", user.IsActive);
            allParam.Add("userType", user.UserType);
            allParam.Add("email", user.Email);

            var result = _dataAccessor.QuerySingle<int>(INSERT_USER, allParam);

            if (result != 0)
            {
                return 0;
            }
            return allParam.Get<int>("id");
        }

        public int DeleteUser(int id)
        {
            var user = GetUser(id);
            user.IsActive = false;
            return UpdateUser(user);
        }

        public bool IsAdminUser()
        {
            return GetCurrentUser().UserType == UserTypeEnum.Admin;
        }

        public bool IsAuthenticated()
        {
            return _loggedInUserId > 0;
        }

        public int Login(string username, string password)
        {
            if (_loggedInUserId > 0)
            {
                return _loggedInUserId;
            }
            // find matching user in db + authenticate
            var users = _dataAccessor.Query<User>(GET_ALL_USERS);
            var user = users.First(u => u.Username == username && u.Password == password);

            if (user == null)
            {
                return 0;
            }

            _loggedInUserId = user.Id;
            return _loggedInUserId;
        }

        public void Logout()
        {
            _loggedInUserId = 0;
        }

        
        public int UpdateUser(User user)
        {
            return _dataAccessor.QuerySingle<int>(UPDATE_USER,
                new {user.Id, user.IsActive, user.Username, user.Password, user.UserType, user.FullName, user.Email});
        }
        public int ActivateUser(int id)
        {
            var user = GetUser(id);
            user.IsActive = true;
            return UpdateUser(user);
        }
    }
}
