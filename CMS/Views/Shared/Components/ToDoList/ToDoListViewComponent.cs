using System.Threading.Tasks;
using CMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Views.Shared.Components.ToDoList
{
    public class ToDoListViewComponent : ViewComponent
    {
        private readonly IAuthService _authService;
        private readonly ITodoService _todoService;
        
        public ToDoListViewComponent(IAuthService authService, ITodoService todoService)
        {
            _authService = authService;
            _todoService = todoService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var todoList = _todoService.GetToDoItems(_authService.GetCurrentUser().Id);

            return View("ToDoList", todoList);
        }

    }
}
