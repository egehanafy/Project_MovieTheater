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
                    registerToken = _userManager.GenerateEmailConfirmationTokenAsync(appUser).Result;

                    MailSender.SendEmail(registerVM.Email, "Confirmation", $"{registerVM.Username} kayit isleminiz olusturuldu. Uyeliginizi asagidaki aktivasyon linkine tiklayarak tamamlayabilirsiniz.");

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}