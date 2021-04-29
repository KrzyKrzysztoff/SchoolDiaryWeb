using SchoolDiaryMVC.Models;
using SchoolDiaryMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Services
{
    public interface IAdminService
    {
        Task<bool> AcceptUserAsync(string id);
        List<ApplicationUser> GetUser();
        Task CreateUserAsync(UserAddressViewModel userAddressViewModel);
        Task UpdateUserAsync(UserAddressViewModel userAddressViewModel);
        Task DeleteUserAsync(string id);
        Task CreateSubject(SubjectViewModel subjectViewModel);
        Task DeleteSubject(int id);
    }
}
