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
        List<StudentGradeViewModel> GetUser();
        StudentGradeViewModel GetUser(string id);
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
        Task AddNoteAsync(NoteViewModel noteViewModel);
        Task DeleteNoteAsync(int id);
        Task AddToClass(ClassGroupViewModel classGroupViewModel);
        Task SetPresence(List<StudentPresenceViewModel> studentPresenceList);
        List<StudentClassViewModel> GetClassById(int id);
        Task<List<StudentPresenceViewModel>> GetClassToSetPresence(int id);
        Task<List<ClassGroupViewModel>> ChooseLesson();
        Task<List<LessonViewModel>> GetLesson(int id);
        Task<List<ClassGroupViewModel>> GetClassGroup();
        Task<UserAddressViewModel> UpdateUser(string id);
        List<Subject> GetSubjectList();
    }
}
