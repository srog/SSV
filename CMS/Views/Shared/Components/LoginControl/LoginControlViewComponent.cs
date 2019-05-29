using CMS.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CMS.Views.Shared.Components.LoginControl
{
    public class LoginControlViewComponent : ViewComponent
    {
        private readonly IAuthService _authService;
        public LoginControlViewComponent(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = _authService.GetCurrentUser();
            return View("LoginControl", user);
        }

    }
}
