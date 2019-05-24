using CMS.Models;
using CMS.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CMS.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IActionResult Index()
        {
            var blogs = _blogService.GetAllBlogs();
            return View(blogs);
        }

        public IActionResult Create()
        {
            return View("Create");
        }
        public IActionResult CreateNewBlog(Blog blog)
        {
            var newId = _blogService.AddBlog(new Blog { CreatedBy = "AdminUser", Name = blog.Name });
            return Blog(newId);
        }

        [HttpPost]
        public ActionResult CreateBlogItem(int blogId, Blog blogRecord)
        {
            var newItem = new BlogItem { BlogId = blogId, Created = DateTime.Now, Text = blogRecord.NewItem };
            _blogService.AddBlogItem(newItem);
            var blog = _blogService.GetBlog(blogId);

            return View("Blog", blog);
        }


        public IActionResult Blog(int id)
        {
            var blog = _blogService.GetBlog(id);
            return View("Blog", blog);
        }

        public IActionResult Delete(int id)
        {
            _blogService.DeleteBlog(id);
            return View("Index");
        }

    }
}