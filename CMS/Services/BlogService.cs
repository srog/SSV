using System.Collections.Generic;
using System.Data;
using System.Linq;
using CMS.DataAccess;
using CMS.Models;
using Dapper;

namespace CMS.Services
{
    public class BlogService : IBlogService
    {
        private readonly IDataAccessor _dataAccessor;
        private const string GET_ALL = "spGetAllBlogs";
        private const string GET = "spGetBlog";
        private const string INSERT = "spInsertBlog";
        private const string UPDATE = "spUpdateBlog";
        private const string DELETE = "spDeleteBlog";

        private const string GET_ITEMS = "spGetBlogItems";
        private const string INSERT_ITEM = "spInsertBlogItem";
        private const string UPDATE_ITEM = "spUpdateBlogItem";
        private const string DELETE_ITEM = "spDeleteBlogItem";

        public BlogService(IDataAccessor dataAccessor)
        {
            _dataAccessor = dataAccessor;
        }

        #region Implementation of IBlogService

        public IEnumerable<Blog> GetAllBlogs()
        {
            var blogList = _dataAccessor.Query<Blog>(GET_ALL);

            return blogList;
        }

        public Blog GetBlog(int id)
        {
            var blog = _dataAccessor.QuerySingle<Blog>(GET, new { id });
            blog.Items = _dataAccessor.Query<BlogItem>(GET_ITEMS, new { blogId = blog.Id}).ToList();
            return blog;
        }

        public int AddBlog(Blog blog)
        {
            var allParam = new DynamicParameters();
            allParam.Add("id", dbType: DbType.Int32, direction: ParameterDirection.Output);
            allParam.Add("name", blog.Name);
            allParam.Add("createdBy", blog.CreatedBy);

            var result = _dataAccessor.QuerySingle<int>(INSERT, allParam);
            if (result != 0)
            {
                return 0; // error
            }
            return allParam.Get<int>("id");

            //return _dataAccessor.Execute(INSERT, new { blog.Id, blog.Name, blog.CreatedBy });

        }

        public int UpdateBlog(Blog blog)
        {
            return _dataAccessor.Execute(UPDATE, new { blog.Id, blog.Name });
        }

        public void DeleteBlog(int id)
        {
            _dataAccessor.Execute(DELETE, new { id });
        }

        public IEnumerable<BlogItem> GetBlogItems(int blogId)
        {
            return _dataAccessor.Query<BlogItem>(GET_ITEMS, new { blogId });
        }

        public int AddBlogItem(BlogItem blogItem)
        {
            return _dataAccessor.Execute(INSERT_ITEM, new { blogItem.Id, blogItem.CreatedBy, blogItem.BlogId, blogItem.Text });
        }

        public int UpdateBlogItem(BlogItem blogItem)
        {
            return _dataAccessor.Execute(UPDATE_ITEM, new { blogItem.Id, blogItem.Text });
        }

        public void DeleteBlogItem(int id)
        {
            _dataAccessor.Execute(DELETE_ITEM, new { id });
        }

        #endregion
    }
}