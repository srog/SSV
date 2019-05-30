using CMS.Models.Enums;
using CMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class TodoListController : Controller
    {
        private readonly ITodoService _todoService;
        private readonly IAuthService _authService;

        public TodoListController(ITodoService todoService, IAuthService authService)
        {
            _todoService = todoService;
            _authService = authService;
        }

        public IActionResult Index()
        {
            var todoList = _todoService.GetToDoItems(_authService.GetCurrentUser().Id);
            return View("Index", todoList);
        }

        public IActionResult DeleteToDoItem(int id)
        {
            var todoItem = _todoService.GetToDoItem(id);
            todoItem.Status = EventStatusEnum.Deleted.GetHashCode();
            _todoService.UpdateToDoItem(todoItem);
            return Index();
        }
        public IActionResult CompleteToDoItem(int id)
        {
            var todoItem = _todoService.GetToDoItem(id);
            todoItem.Status = EventStatusEnum.Complete.GetHashCode();
            _todoService.UpdateToDoItem(todoItem);
            return Index();
        }
    }
}