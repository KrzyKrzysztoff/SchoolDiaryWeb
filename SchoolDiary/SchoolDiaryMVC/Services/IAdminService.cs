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
        Task CreateSubjectAsync(SubjectViewModel subjectViewModel);
        Task DeleteSubjectAsync(int id);
        List<Subject> GetSubject();
        Task CreateClassGroupAsync(ClassGroupViewModel classGroupViewModel);
        Task DeleteClassGroupAsync(int id);
        Task DeleteLessonAsync(int id);
        Task CreateLessonAsync(LessonViewModel lessonViewModel);
        Task CreateGradeAsync(GradeViewModel gradeViewModel);
        Task DeleteGradeAsync(int id);
    }
}
