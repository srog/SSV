﻿using System.Collections.Generic;
using System.Data;
using System.Linq;
using CMS.DataAccess;
using CMS.Models;
using Dapper;

namespace CMS.Services
{
    public interface IBlogService
    {
        IEnumerable<Blog> GetAllBlogs();
        Blog GetBlog(int id);
        int AddBlog(Blog blog);
        int UpdateBlog(Blog blog);
        void DeleteBlog(int id);
        
        IEnumerable<BlogItem> GetBlogItems(int blogId);
        IEnumerable<BlogItem> GetAllBlogItems();

        BlogItem GetBlogItem(int itemId);
        int AddBlogItem(BlogItem blogItem);
        int UpdateBlogItem(BlogItem blogItem);
        void DeleteBlogItem(int id);

    }
    public class BlogService : IBlogService
    {
        private readonly IDataAccessor _dataAccessor;
        private readonly IAuthService _authService;

        private const string GET_ALL = "spGetAllBlogs";
        private const string GET = "spGetBlog";
        private const string INSERT = "spInsertBlog";
        private const string UPDATE = "spUpdateBlog";
        private const string DELETE = "spDeleteBlog";

        private const string GET_ITEMS = "spGetBlogItems";
        private const string GET_ALL_ITEMS = "spGetAllBlogItems";
        private const string GET_ITEM = "spGetBlogItem";
        private const string INSERT_ITEM = "spInsertBlogItem";
        private const string UPDATE_ITEM = "spUpdateBlogItem";
        private const string DELETE_ITEM = "spDeleteBlogItem";

        public BlogService(IDataAccessor dataAccessor, IAuthService authService)
        {
            _dataAccessor = dataAccessor;
            _authService = authService;
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
            blog.Items = GetBlogItems(id).OrderByDescending(b => b.Created).ToList();
            return blog;
        }

        public int AddBlog(Blog blog)
        {
            var allParam = new DynamicParameters();
            allParam.Add("id", dbType: DbType.Int32, direction: ParameterDirection.Output);
            allParam.Add("name", blog.Name);
            allParam.Add("createdByUser", blog.CreatedByUser);

            var result = _dataAccessor.QuerySingle<int>(INSERT, allParam);
            if (result != 0)
            {
                return 0; 
            }
            return allParam.Get<int>("id");
            
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
        public IEnumerable<BlogItem> GetAllBlogItems()
        {
            return _dataAccessor.Query<BlogItem>(GET_ALL_ITEMS);
        }

        public BlogItem GetBlogItem(int blogItemId)
        {
            return _dataAccessor.QuerySingle<BlogItem>(GET_ITEM, new {blogItemId});
        }

        public int AddBlogItem(BlogItem blogItem)
        {
            return _dataAccessor.Execute(INSERT_ITEM, new {
                blogItem.Id,
                blogItem.CreatedByUser,
                blogItem.BlogId,
                blogItem.Text
            });
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