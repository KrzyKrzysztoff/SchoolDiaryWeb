using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolDiaryMVC.Data;
using SchoolDiaryMVC.Models;
using SchoolDiaryMVC.Services;
using SchoolDiaryMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IAdminService adminService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly AppDbContext dbContext;

        public AdminController(RoleManager<IdentityRole> roleManager, IAdminService adminService, UserManager<ApplicationUser> userManager , AppDbContext dbContext)
        {
            this.roleManager = roleManager;
            this.adminService = adminService;
            this.userManager = userManager;
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetRole()
        {
            var listRole = roleManager.Roles.ToList();
            if (TempData["Success"] != null)
            {
                ViewData["Success"] = TempData["Success"].ToString();
            }
            if (TempData["Error"] != null)
            {
                ViewData["Error"] = TempData["Error"].ToString();
            }
            return View(listRole);
        }
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel roleViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (roleViewModel.Name == null)
                    {
                        ViewData["Error"] = "Nazwa nie może być pusta";
                        return View(roleViewModel.Name);
                    }
                    if (await roleManager.RoleExistsAsync(roleViewModel.Name))
                    {
                        ViewData["Error"] = "Uprawienia o tej nazwie już istnieją";
                        return View();
                    }
                    IdentityRole identityRole = new IdentityRole()
                    {
                        Name = roleViewModel.Name,
                        NormalizedName = roleViewModel.Name.Normalize(),
                    };
                    var result = await roleManager.CreateAsync(identityRole);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("GetRole", "Admin");
                    }
                    ModelState.AddModelError(string.Empty, "Uprawnienia nie zostały stworzone");
                    return View(roleViewModel.Name);
                }
                ModelState.AddModelError(string.Empty, "Uprawenia nie zostały stworzone");
                return View(roleViewModel.Name);
            }
            catch (Exception ex)
            {
                return View(ex);
            }

        }

        [HttpPost]
        public async Task<IActionResult> DeleteRole(string name)
        {
            if (await roleManager.RoleExistsAsync(name))
            {
                var role = await roleManager.FindByNameAsync(name);
                var result = await roleManager.DeleteAsync(role);
                if (result.Succeeded)
                {
                    // ViewData["Success"] = "Uprawnienia zostały usunięte";
                    TempData["Success"] = "Uprawnienia zostały usunięte";
                }
                return RedirectToAction("GetRole");
            }
            // ViewData["Error"] = "Nie można usunać uprawnienia";
            TempData["Error"] = "Nie można usunać uprawnienia";
            return RedirectToAction("GetRole");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            RoleViewModel roleViewModel = new RoleViewModel() { Id = id, Name = role.Name };
            return View(roleViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRole(RoleViewModel roleViewModel)
        {
            try
            {
                var newRole = await roleManager.FindByIdAsync(roleViewModel.Id);
                newRole.Name = roleViewModel.Name;
                var result = await roleManager.UpdateAsync(newRole);
                if (result.Succeeded)
                {
                    TempData["Success"] = "Uprawnienia zostały edytowane";
                    return RedirectToAction("GetRole");
                }
                ViewData["Error"] = "Uprawnienia nie zostały edytowane";
                return View();
            }
            catch (Exception ex)
            {

                return View(ex.Message);
            }

        }
        
        [HttpGet]
        public IActionResult AddToRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddToRole(UserRoleViewModel userRoleViewModel)
        {
            var role = await roleManager.FindByNameAsync(userRoleViewModel.RoleName);
            if (role != null)
            {
                var user = await userManager.FindByEmailAsync(userRoleViewModel.UserEmail);
                if (user != null)
                {
                    if (!await userManager.IsInRoleAsync(user, role.Name))
                    {
                        var result = await userManager.AddToRoleAsync(user, role.Name);
                        if (result.Succeeded)
                        {
                            ViewData["Success"] = "Uprawnienia zostały nadane";
                            return View();
                        }
                        else
                        {
                            ViewData["Error"] = "Nie można nadać uprawnień";
                            return View(userRoleViewModel);
                        }
                    }
                    else
                    {
                        ViewData["Error"] = "Podany użytkownik posiada już uprawnienia";
                        return View(userRoleViewModel);
                    }
                }
                else
                {
                    ViewData["Error"] = "Użytkownik nie istenieje";
                    return View(userRoleViewModel);
                }
            }
            else
            {
                ViewData["Error"] = "Uprawnienia nie istnieją";
                return View(userRoleViewModel);
            }
        }
        [HttpGet]
        public IActionResult GetUser()
        {
            if (TempData["Success"] != null)
            {
                ViewData["Success"] = TempData["Success"].ToString();
            }
            if (TempData["Error"] != null)
            {
                ViewData["Error"] = TempData["Error"].ToString();
            }
            var userList = adminService.GetUser();
            return View(userList);
        }
        [HttpPost]
        public async Task<IActionResult> AcceptUser(string id)
        {
            var result = await adminService.AcceptUserAsync(id);
            if (result == true)
            {
                TempData["Success"] = "Użytkownik został zaakceptowany";
                return RedirectToAction("GetUser");
            }
            TempData["Error"] = "Użytkownik nie może zostać zaakceptowany";
            return RedirectToAction("GetUser");
        }
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(UserAddressViewModel userAddressViewModel)
        {
            await adminService.CreateUserAsync(userAddressViewModel);
            ViewData["Success"] = "Użytkownik został utworzony";
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            UserAddressViewModel userAddressViewModel = new UserAddressViewModel();

            if (userAddressViewModel != null)
            {
                userAddressViewModel.BirthDate = user.BirthDate;
                userAddressViewModel.Course = user.Course;
                userAddressViewModel.Email = user.Email;
                userAddressViewModel.FirstName = user.FirstName;
                userAddressViewModel.Gender = user.Gender;
                userAddressViewModel.Index = user.Index;
                userAddressViewModel.LastName = user.LastName;
                userAddressViewModel.UserType = user.UserType;
                userAddressViewModel.Accepted = user.Accepted;
            }
            return View(userAddressViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUser(UserAddressViewModel userAddressViewModel)
        {
            await adminService.UpdateUserAsync(userAddressViewModel);
            ViewData["Success"] = "Użytkownik został edytowany";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id)
        {
            await adminService.DeleteUserAsync(id);
            TempData["Success"] = "Użytkownik został usunięty";
            return RedirectToAction("GetUser");
        }
        [HttpGet]
        public IActionResult CreateSubject()
        {
            return View();
        }
        [HttpPost]
        //Tutaj skonczylem na tworzeniu, jeszcze usuwanie
        public async Task<IActionResult> CreateSubject(SubjectViewModel subjectViewModel)
        {
            await adminService.CreateSubject(subjectViewModel);
            return View();
        }
    }
}
