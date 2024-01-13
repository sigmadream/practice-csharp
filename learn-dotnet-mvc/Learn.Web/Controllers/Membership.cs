using Microsoft.AspNetCore.Mvc;
using Learn.Services.Interfaces;
using Learn.Services.Svcs;
using Learn.Data.ViewModels;

namespace Learn.Web.Controllers
{
    public class Membership : Controller
    {
        // private IUser _user = new UserService();
        private IUser _user;

        public Membership(IUser user)
        {
            _user = user;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Login(LoginInfo login)
        {
            string message = string.Empty;

            if (ModelState.IsValid)
            {
                if (_user.MatchTheUserInfo(login))
                {
                    TempData["Message"] = "로그인에 성공했습니다.";
                    return RedirectToAction("Index", "Membership");
                }
                else
                {
                    message = "ID와 비밀번호를 확인해주세요.";
                }
            }
            else
            {
                message = "로그인 정보가 올바르지 않습니다.";
            }
            ModelState.AddModelError(string.Empty, message);
            return View();
        }
    }
}
