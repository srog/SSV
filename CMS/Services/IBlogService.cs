using System.Collections.Generic;
using CMS.Models;

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
}