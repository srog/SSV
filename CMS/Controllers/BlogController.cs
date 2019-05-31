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
            var newId = _blogService.AddBlog(new Blog
            {
                CreatedByUser = _authService.GetCurrentUser().Id,
                Name = blog.Name
            });
            return Blog(newId);
        }

        [HttpPost]
        public IActionResult CreateBlogItem(int blogId, Blog blogRecord)
        {
            var user = _authService.GetCurrentUser();

            var newItem = new BlogItem {
                BlogId = blogId,
                Created = DateTime.Now,
                CreatedByUser = user.Id,
                Text = blogRecord.NewItem
            };
            _blogService.AddBlogItem(newItem);

            return Blog(blogId);
        }


        public IActionResult Blog(int id)
        {
            ModelState.Clear();
            var blog = _blogService.GetBlog(id);
            return View("Blog", blog);
        }

        // only delete own
        public RedirectToActionResult Delete(int id)
        {
            var blog = _blogService.GetBlog(id);
            if ((blog != null && _authService.GetCurrentUser().Id == blog.CreatedByUser) || (_authService.IsAdminUser()))
            {
                _blogService.DeleteBlog(id);
            }

            ModelState.Clear();
            return RedirectToAction("Index");
        }

        //only delete own ?
        public RedirectToActionResult DeleteItem(int id, int blogId)
        {
            var blogItem = _blogService.GetBlogItem(id);
            if ((blogItem != null && _authService.GetCurrentUser().Id == blogItem.CreatedByUser) || _authService.IsAdminUser())
            {
                _blogService.DeleteBlogItem(id);
            }

            ModelState.Clear();
            return RedirectToAction("Blog", blogId);
        }
    }
}