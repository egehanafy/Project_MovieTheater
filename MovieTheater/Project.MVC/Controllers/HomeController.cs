using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.BLL.AbstractService;
using Project.BLL.Service;
using Project.Common;
using Project.Entity.Entity;
using Project.MVC.Models;
using Project.MVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(IMovieService movieService, UserManager<AppUser> userManager)
        {
            _movieService = movieService;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                //kullanici bilgilerini aldiktan sonra kayit islemi ardindan kullanicinin mail adresine konfirmasyon mailinin gonderilmesi

                AppUser appUser = new AppUser
                {
                    UserName = registerVM.Username,
                    Email = registerVM.Email
                };

                var result = await _userManager.CreateAsync(appUser, registerVM.ConfirmPassword);

                var registerToken = "";

                if (result.Succeeded)
                {
                    while (true)
                    {
                        registerToken = _userManager.GenerateEmailConfirmationTokenAsync(appUser).Result;

                        if (!registerToken.Contains("/")&&!registerToken.Contains("+"))
                        {
                            break;
                        }
                    }

                    MailSender.SendEmail(registerVM.Email, "Confirmation", $"{registerVM.Username} kayit isleminiz olusturuldu. Uyeliginizi asagidaki aktivasyon linkine tiklayarak tamamlayabilirsiniz. https://localhost:44313/home/confirmation"+appUser.Id+"/"+registerToken);

                    TempData["result"] = $"{appUser.UserName} adresine aktivasyon maili gonderildi. Lutfen e-mailinizi kontrol ediniz.";

                    return View();
                }
                else
                {
                    return View();
                }

            }
            else
            {
                return View(registerVM);
            }
        }

        public async Task<IActionResult> Confirmation(int id, string registerCode)
        {
            if (id != null && registerCode != null)
            {
                var user = await _userManager.FindByIdAsync(id.ToString());

                var confirm = await _userManager.ConfirmEmailAsync(user, registerCode);

                if (confirm.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}