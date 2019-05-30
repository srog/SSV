using System.Collections.Generic;
using System.Data;
using CMS.DataAccess;
using CMS.Models;
using Dapper;

namespace CMS.Services
{
    public interface ITodoService
    {
        IEnumerable<ToDoItem> GetToDoItems(int userId);
        ToDoItem GetToDoItem(int id);
        int AddToDoItem(ToDoItem item);
        int UpdateToDoItem(ToDoItem item);
    }

    public class TodoService : ITodoService
    {
        private readonly IDataAccessor _dataAccessor;
        private const string GET_ALL_FOR_USER = "spGetToDoItems";
        private const string INSERT = "spInsertToDoItem";
        private const string UPDATE = "spUpdateToDoItem";
        private const string GET = "spGetToDoItem";

        #region Implementation of ITodoService

        public IEnumerable<ToDoItem> GetToDoItems(int userId)
        {
            return _dataAccessor.Query<ToDoItem>(GET_ALL_FOR_USER, new {userId});
        }

        public ToDoItem GetToDoItem(int id)
        {
            return _dataAccessor.QuerySingle<ToDoItem>(GET, new {id});
        }

        public int AddToDoItem(ToDoItem item)
        {
            var allParam = new DynamicParameters();
            allParam.Add("id", dbType: DbType.Int32, direction: ParameterDirection.Output);
            allParam.Add("name", item.Name);
            allParam.Add("userId", item.UserId);
            allParam.Add("status", item.Status);

            var result = _dataAccessor.QuerySingle<int>(INSERT, allParam);
            if (result != 0)
            {
                return 0;
            }
            return allParam.Get<int>("id");

        }

        public int UpdateToDoItem(ToDoItem item)
        {
            return _dataAccessor.QuerySingle<int>(UPDATE, new {item.Id, item.Name, item.Status});
        }

        #endregion
    }
}