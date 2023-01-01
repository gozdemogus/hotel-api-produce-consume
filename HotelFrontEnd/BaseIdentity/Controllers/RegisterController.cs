using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseIdentity.EntityLayer.Concrete;
using BaseIdentity.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BaseIdentity.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index(int x)
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Index(AppUserRegisterViewModel p)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        AppUser appUser = new AppUser()
        //        {
        //            Name = p.Name,
        //            Surname = p.Surname,
        //            Email = p.Mail,
        //            UserName = p.Username
        //        };

        //        if (p.Password == p.ConfirmPassword)
        //        {
        //            var result = await _userManager.CreateAsync(appUser, p.Password);

        //            if (result.Succeeded)
        //            {
        //                return RedirectToAction("Index", "Login");
        //            }
        //            else
        //            {
        //                foreach (var item in result.Errors)
        //                {
        //                    ModelState.AddModelError("", item.Description);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Şifreler birbiriyle uyuşmuyor");
        //        }
        //    }

        //    return View();
        //}
    }
}

