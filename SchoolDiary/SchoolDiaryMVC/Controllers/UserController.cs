using Microsoft.AspNetCore.Mvc;
using SchoolDiaryMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService) 
        {
            this.userService = userService;
        }
        [HttpGet]
        public IActionResult Profile(string id)
        {
            var user = userService.GetProfile(id);
            return View(user);
        }
      
    }
}
