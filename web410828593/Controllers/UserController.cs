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
        //https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/working-with-sql?view=aspnetcore-5.0&tabs=visual-studio-code
        // GET: /<controller>/
        public IActionResult SignUp()
        {
            // 使用者第一次瀏覽，沒有資料，所以要自行 new SignUpData() 傳入 View() 中
            return View(new SignUpData());
        }

        [HttpPost]

        public IActionResult SignUp(SignUpData data)
        {
            if (ModelState.IsValid) {
                data.Message = "註冊成功";
            }
            //if (data.Name != ""&& data.Name != null &&
            //    data.Password != "" && data.Password != null &&
            //    data.Account != "" && data.Account != null) {
            //    data.Message = "註冊成功";
            //}
            return View(data);
        }
    }
}
