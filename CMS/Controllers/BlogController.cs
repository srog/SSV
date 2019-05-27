using CMS.Models;
using CMS.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CMS.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly IAuthService _authService;

        public BlogController(IBlogService blogService, IAuthService authService)
        {
            _blogService = blogService;
            _authService = authService;
        }
        public IActionResult Index()
        {
            var blogs = _blogService.GetAllBlogs();
            return View("Index", blogs);
        }

        public IActionResult Create()
        {
            return View("Create");
        }
        public IActionResult CreateNewBlog(Blog blog)
        {
            var newId = _blogService.AddBlog(new Blog { CreatedBy = _authService.GetCurrentUser(), Name = blog.Name });
            return Blog(newId);
        }

        [HttpPost]
        public IActionResult CreateBlogItem(int blogId, Blog blogRecord)
        {
            var newItem = new BlogItem {
                BlogId = blogId,
                Created = DateTime.Now,
                CreatedBy = _authService.GetCurrentUser(),
                Text = blogRecord.NewItem
            };
            _blogService.AddBlogItem(newItem);
            //var blog = _blogService.GetBlog(blogId);


            return Blog(blogId);// View("Blog", blog);
        }


        public IActionResult Blog(int id)
        {
            ModelState.Clear();
            var blog = _blogService.GetBlog(id);
            return View("Blog", blog);
        }

        public IActionResult Delete(int id)
        {
            _blogService.DeleteBlog(id);
            ModelState.Clear();
            return Index();
        }
        public IActionResult DeleteItem(int id, int blogId)
        {
            _blogService.DeleteBlogItem(id);
            return Blog(blogId);
        }
    }
}