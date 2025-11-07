using Microsoft.AspNetCore.Mvc;
using sample02.Models;

namespace sample02.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, int age)
        {
            //モデルにでーたをつめる 
            var user = new UserModel
            {
                Name = name,
                Age = age
            };
            //ビューにモデルを渡す
            return View(user);

        }
    }
}
