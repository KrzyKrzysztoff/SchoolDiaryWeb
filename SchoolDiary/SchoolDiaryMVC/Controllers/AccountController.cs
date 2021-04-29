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
                        return RedirectToAction("Main", "User");
                    }
                    else
                    {
                        await signInManager.SignOutAsync();
                        ViewData["Wait"] = "Użytkownik nie został jeszcze zaakacpetowany";
                    }
                }
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
                //here have to wait for Administration accept(do this better), if user is accepted .
                var result = await userManager.CreateAsync(applicationUser, registerViewModel.Password);
                if (result.Succeeded)
                {
                    // await signInManager.SignInAsync(applicationUser, registerViewModel.RememberMe);
                    ViewData["Wait"] = "Użytkownik nie został jeszcze zaakacpetowany";
                    return View(registerViewModel);
                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, item.Description);
                }
                ModelState.AddModelError(string.Empty, "Logowanie nie powiodło się");
            }
            return View(registerViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}

