using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web410828593.ViewModels;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web410828593.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult SignUp()
        {
            // 使用者第一次瀏覽，沒有資料，所以要自行 new SignUpData() 傳入 View() 中
            return View(new SignUpData());
        }

        [HttpPost]

        public IActionResult SignUp(SignUpData data)
        {
            if (data.Name == null || data.Name=="")
            {
                data.NameMessage = "請輸入姓名";
            }
            if (data.Account == null || data.Account == "")
            {
                data.AccountMessage = "請輸入帳號";
            }
            if (data.Password == null || data.Password == "")
            {
                data.PasswordMessage = "請輸入密碼";
            }
            if (data.Name != ""&& data.Name != null &&
                data.Password != "" && data.Password != null &&
                data.Account != "" && data.Account != null) {
                data.Message = "註冊成功";
            }
            return View(data);
        }
    }
}
