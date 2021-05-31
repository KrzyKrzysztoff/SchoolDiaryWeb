using SchoolDiaryMVC.Data;
using SchoolDiaryMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Services
{
    public class UsersService:IUserService
    {
        private readonly AppDbContext appDbContext;

        public UsersService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public UserAddressViewModel GetProfile(string id)
        {
            
            var user = appDbContext.ApplicationUsers.FirstOrDefault(x => x.Id == id);
            UserAddressViewModel userAddressViewModel = new UserAddressViewModel()
            {
                Accepted = user.Accepted,
                Id = user.Id,
                BirthDate = user.BirthDate,
                Course = user.Course,
                FirstName = user.FirstName,
                Email = user.Email,
                Gender = user.Gender,
                Index = user.Index,
                LastName = user.LastName,
                Pesel = user.Pesel,
                WorkedHours = user.WorkedHours,
                UserType = user.UserType,
                SalaryPerHour = user.SalaryPerHour,

            };
            return userAddressViewModel;
        }
    }
}
