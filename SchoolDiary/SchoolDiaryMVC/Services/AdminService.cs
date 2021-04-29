using Microsoft.AspNetCore.Identity;
using SchoolDiaryMVC.Data;
using SchoolDiaryMVC.Models;
using SchoolDiaryMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Services
{


    public class AdminService : IAdminService
    {
        private readonly AppDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public AdminService(AppDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }
        //Here have to display Addres and User table together(use Join)
        public List<ApplicationUser> GetUser()
        {
            try
            {
                var userList = dbContext.ApplicationUsers.ToList();
                return userList;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public async Task<bool> AcceptUserAsync(string id)
        {
            var user = dbContext.ApplicationUsers.First(x => x.Id == id);
            if (user != null)
            {
                if (user.Accepted == false)
                {
                    user.Accepted = true;
                    await dbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            return false;

        }
        public async Task CreateUserAsync(UserAddressViewModel userAddressViewModel)
        {
            try
            {
                Address address = new Address()
                {
                    Country = userAddressViewModel.Country,
                    City = userAddressViewModel.City,
                    HouseNumber = userAddressViewModel.HouseNumber,
                    PostalCode = userAddressViewModel.PostalCode,
                    Street = userAddressViewModel.Street,
                };
                ApplicationUser applicationUser = new ApplicationUser()
                {
                    UserType = userAddressViewModel.UserType,
                    SalaryPerHour = userAddressViewModel.SalaryPerHour,
                    Pesel = userAddressViewModel.Pesel,
                    FirstName = userAddressViewModel.FirstName,
                    LastName = userAddressViewModel.LastName,
                    Email = userAddressViewModel.Email,
                    Gender = userAddressViewModel.Gender,
                    WorkedHours = userAddressViewModel.WorkedHours,
                    BirthDate = userAddressViewModel.BirthDate,
                    Index = userAddressViewModel.Index,
                    Course = userAddressViewModel.Course,
                    Accepted = true,
                    UserName = userAddressViewModel.Email,
                    NormalizedEmail = userManager.NormalizeEmail(userAddressViewModel.Email),
                };
                await userManager.CreateAsync(applicationUser, userAddressViewModel.Password);
                await dbContext.Addresses.AddAsync(address);
                await dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
        public async Task UpdateUserAsync(UserAddressViewModel userAddressViewModel)
        {
            try
            {
                var newUser = await userManager.FindByIdAsync(userAddressViewModel.Id);
                if (newUser != null)
                {
                    newUser.Accepted = userAddressViewModel.Accepted;
                    newUser.BirthDate = userAddressViewModel.BirthDate;
                    newUser.Course = userAddressViewModel.Course;
                    newUser.Email = userAddressViewModel.Email;
                    newUser.FirstName = userAddressViewModel.FirstName;
                    newUser.Gender = userAddressViewModel.Gender;
                    newUser.Index = userAddressViewModel.Index;
                    newUser.LastName = userAddressViewModel.LastName;
                    newUser.UserType = userAddressViewModel.UserType;
                    newUser.WorkedHours = userAddressViewModel.WorkedHours;
                    newUser.Pesel = userAddressViewModel.Pesel;
                    newUser.UserName = userAddressViewModel.Email;
                    newUser.NormalizedEmail = userManager.NormalizeEmail(userAddressViewModel.Email);
                    newUser.NormalizedUserName = userManager.NormalizeEmail(userAddressViewModel.Email);

                    await dbContext.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("Użytkownik nie istenieje");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public async Task DeleteUserAsync(string id)
        {
            try
            {
                var user = dbContext.Users.First(x => x.Id == id);
                dbContext.Users.Remove(user);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public async Task CreateSubject(SubjectViewModel subjectViewModel)
        {
            try
            {
                Subject subject = new Subject();
                var teacher = dbContext.ApplicationUsers.Where(x => x.UserType == UserTypeEnum.Teacher).First(y => y.Id == subjectViewModel.TeacherId);
                subject.SubjectName = subjectViewModel.SubjectName;
                subject.Teacher = teacher;
                await dbContext.Subjects.AddAsync(subject);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
        public async Task DeleteSubject(int id)
        {
            try
            {
                var subject = dbContext.Subjects.First(x => x.Id == id);
                dbContext.Subjects.Remove(subject);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
          
        }

    }
}
