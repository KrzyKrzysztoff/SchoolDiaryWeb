using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolDiaryMVC.Models;
using SchoolDiaryMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;

        public AccountController(SignInManager<ApplicationUser> signInManager,
                                 UserManager<ApplicationUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(loginViewModel.Email);


                var result = await signInManager.PasswordSignInAsync(loginViewModel.Email, loginViewModel.Password, loginViewModel.RememberMe, false);
                if (result.Succeeded)
                {
                    if (user.Accepted == true)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        await signInManager.SignOutAsync();
                        ViewData["Wait"] = "Użytkownik nie został jeszcze zaakacpetowany";
                    }
                }
                ViewData["Error"] = "Niepoprawne hasło lub email";
                ModelState.AddModelError(string.Empty, "Logowanie nie powiodło się");
                return View(loginViewModel);
            }
            return View(loginViewModel);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {

                ApplicationUser applicationUser = new ApplicationUser()
                {
                    Email = registerViewModel.Email,
                    UserName = registerViewModel.Email,
                    UserType = registerViewModel.UserType,
                    FirstName = registerViewModel.FirstName,
                    Pesel = registerViewModel.Pesel,
                };        
                var user = await userManager.FindByEmailAsync(applicationUser.Email);
                if (user != null)
                {
                    ViewData["Error"] = "Podany użytkownik już istnieje";
                }
                var result = await userManager.CreateAsync(applicationUser, registerViewModel.Password);
                if (result.Succeeded)
                {
                    ViewData["Wait"] = "Użytkownik musi musi zostać zaakceptowany. Wróć tu później";
                    return View(registerViewModel);
                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, item.Description);
                }
                ViewData["Error"] = "Użytkownik nie może zostać stworzony";
                ModelState.AddModelError(string.Empty, "Logowanie nie powiodło się");
            }
            return View(registerViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

    }
}

