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
   
        public List<StudentGradeViewModel> GetUser()
        {

            List<StudentGradeViewModel> studentGradeList = new List<StudentGradeViewModel>();
            try
            {
                var userList = dbContext.ApplicationUsers.ToList();

                foreach (var user in userList)
                {
                    StudentGradeViewModel studentGradeViewModel = new StudentGradeViewModel();
                    var grades = dbContext.Grades.Where(x => x.StudentId == user.Id).ToList();
                    foreach (var grade in grades)
                    {
                        if (grade != null)
                        {
                            GradeViewModel gradeViewModel = new GradeViewModel();
                            var lesson = dbContext.Lessons.FirstOrDefault(v => v.Id == grade.LessonId);
                            var subject = dbContext.Subjects.FirstOrDefault(y => y.Id == lesson.SubjectId);
                            var teacher = dbContext.ApplicationUsers.FirstOrDefault(x => x.Id == subject.TeacherId);

                            gradeViewModel.Id = grade.Id;
                            gradeViewModel.Date = grade.Date;
                            gradeViewModel.IsFinalGrade = grade.IsFinalGrade;
                            gradeViewModel.Rating = grade.Rating;
                            gradeViewModel.SubjectName = subject.SubjectName;
                            gradeViewModel.LessonType = lesson.LessonType;
                            gradeViewModel.TeacherEmail = teacher.Email;

                            studentGradeViewModel.Grades.Add(gradeViewModel);
                        }

                    }
                    var notes = dbContext.Notes.Where(z => z.StudentId == user.Id).ToList();
                    foreach (var note in notes)
                    {
                        if (note != null)
                        {
                            var lesson = dbContext.Lessons.FirstOrDefault(x => x.Id == note.Id);
                            NoteViewModel noteViewModel = new NoteViewModel();
                            noteViewModel.IsPositive = note.IsPositive;
                            noteViewModel.Desc = note.Description;
                            noteViewModel.Date = note.Date;
                            noteViewModel.Id = note.Id;

                            studentGradeViewModel.Notes.Add(noteViewModel);
                        }

                    }
                    studentGradeViewModel.Id = user.Id;
                    studentGradeViewModel.FirstName = user.FirstName;
                    studentGradeViewModel.LastName = user.LastName;
                    studentGradeViewModel.Pesel = user.Pesel;
                    studentGradeViewModel.Index = user.Index;
                    studentGradeViewModel.Course = user.Course;
                    studentGradeViewModel.UserType = user.UserType;
                    studentGradeViewModel.IsAccepted = user.Accepted;
                    studentGradeList.Add(studentGradeViewModel);


                }

                return studentGradeList;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public StudentGradeViewModel GetUser(string id)
        {


            try
            {
                var user = dbContext.ApplicationUsers.FirstOrDefault(x => x.Id == id);

                StudentGradeViewModel studentGradeViewModel = new StudentGradeViewModel();
                var grades = dbContext.Grades.Where(x => x.StudentId == id).ToList();
                foreach (var grade in grades)
                {
                    if (grade != null)
                    {
                        GradeViewModel gradeViewModel = new GradeViewModel();
                        var lesson = dbContext.Lessons.FirstOrDefault(v => v.Id == grade.LessonId);
                        var subject = dbContext.Subjects.FirstOrDefault(y => y.Id == lesson.SubjectId);
                        var teacher = dbContext.ApplicationUsers.FirstOrDefault(x => x.Id == subject.TeacherId);

                        gradeViewModel.Id = grade.Id;
                        gradeViewModel.Date = grade.Date;
                        gradeViewModel.IsFinalGrade = grade.IsFinalGrade;
                        gradeViewModel.Rating = grade.Rating;
                        gradeViewModel.SubjectName = subject.SubjectName;
                        gradeViewModel.LessonType = lesson.LessonType;
                        gradeViewModel.TeacherEmail = teacher.Email;

                        studentGradeViewModel.Grades.Add(gradeViewModel);
                    }

                }
                var notes = dbContext.Notes.Where(z => z.StudentId == id).ToList();
                foreach (var note in notes)
                {
                    if (note != null)
                    {
                        var lesson = dbContext.Lessons.FirstOrDefault(x => x.Id == note.Id);
                        NoteViewModel noteViewModel = new NoteViewModel();
                        noteViewModel.IsPositive = note.IsPositive;
                        noteViewModel.Desc = note.Description;
                        noteViewModel.Date = note.Date;
                        noteViewModel.Id = note.Id;

                        studentGradeViewModel.Notes.Add(noteViewModel);
                    }

                }
                studentGradeViewModel.FirstName = user.FirstName;
                studentGradeViewModel.LastName = user.LastName;
                studentGradeViewModel.Pesel = user.Pesel;
                studentGradeViewModel.Index = user.Index;
                studentGradeViewModel.Course = user.Course;
                studentGradeViewModel.UserType = user.UserType;
                studentGradeViewModel.IsAccepted = user.Accepted;


                return studentGradeViewModel;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public async Task<bool> AcceptUserAsync(string id)
        {
            try
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
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


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
        public async Task CreateSubjectAsync(SubjectViewModel subjectViewModel)
        {
            try
            {
                Subject subject = new Subject();
                var teacher = dbContext.ApplicationUsers.Where(x => x.UserType == UserTypeEnum.Teacher).First(y => y.Id == subjectViewModel.TeacherId);
                subject.SubjectName = subjectViewModel.SubjectName;
                //subject.TeacherId = teacher.Id;
                subject.Teacher = teacher;
                await dbContext.Subjects.AddAsync(subject);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public async Task DeleteSubjectAsync(int id)
        {
            try
            {
                var subject = dbContext.Subjects.First(x => x.Id == id);

                dbContext.Subjects.Remove(subject);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public List<Subject> GetSubject()
        {
            try
            {
                var subjects = dbContext.Subjects.ToList();
                return subjects;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public async Task CreateClassGroupAsync(ClassGroupViewModel classGroupViewModel)
        {
            try
            {
                var teacher = dbContext.ApplicationUsers.Where(x => x.UserType == UserTypeEnum.Teacher).First(y => y.Id == classGroupViewModel.ClassTeacherId);
                if (teacher != null)
                {

                    ClassGroup classGroup = new ClassGroup()
                    {
                        ClassGroupTeacher = teacher,
                        Course = classGroupViewModel.Course,
                        SizeGroup = classGroupViewModel.SizeGroup,
                        ClassMark = classGroupViewModel.ClassMark
                    };
                    await dbContext.ClassesGroup.AddAsync(classGroup);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public async Task DeleteClassGroupAsync(int id)
        {
            try
            {
                var classGroup = dbContext.ClassesGroup.FirstOrDefault(x => x.Id == id);
                dbContext.Remove(classGroup);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public async Task CreateLessonAsync(LessonViewModel lessonViewModel)
        {

            try
            {

                var classGroup = dbContext.ClassesGroup.FirstOrDefault(x => x.Id == lessonViewModel.ClassGroupId);
                var subject = dbContext.Subjects.FirstOrDefault(y => y.Id == lessonViewModel.SubjectNameId);

                Lesson lesson = new Lesson()
                {
                    LessonType = lessonViewModel.LessonType,
                    ClassGroup = classGroup,
                    Date = lessonViewModel.Date,
                    End = lessonViewModel.End,
                    Start = lessonViewModel.Start,
                    Subject = subject,
                };
                await dbContext.Lessons.AddAsync(lesson);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public async Task DeleteLessonAsync(int id)
        {
            try
            {
                var lesson = dbContext.Lessons.FirstOrDefault(x => x.Id == id);
                dbContext.Lessons.Remove(lesson);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public async Task CreateGradeAsync(GradeViewModel gradeViewModel)
        {
            try
            {
                var lesson = dbContext.Lessons.FirstOrDefault(x => x.Id == gradeViewModel.LessonId);
                var student = dbContext.ApplicationUsers.FirstOrDefault(x => x.Id == gradeViewModel.StudentId);
                Grade grade = new Grade()
                {
                    Date = gradeViewModel.Date,
                    Lesson = lesson,
                    Rating = gradeViewModel.Rating,
                    Student = student,
                    IsFinalGrade = gradeViewModel.IsFinalGrade
                };
                await dbContext.Grades.AddAsync(grade);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public async Task DeleteGradeAsync(int id)
        {
            try
            {
                var grade = dbContext.Grades.FirstOrDefault(x => x.Id == id);
                dbContext.Remove(grade);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public async Task AddNoteAsync(NoteViewModel noteViewModel)
        {
            try
            {
                if (noteViewModel != null)
                {
                    var student = dbContext.ApplicationUsers.FirstOrDefault(x => x.Id == noteViewModel.StudentId);
                    var lesson = dbContext.Lessons.FirstOrDefault(x => x.Id == noteViewModel.LessonId);
                    Note note = new Note()
                    {
                        Description = noteViewModel.Desc,
                        IsPositive = noteViewModel.IsPositive,
                        Lesson = lesson,
                        Student = student,
                        Date = noteViewModel.Date
                    };
                    await dbContext.Notes.AddAsync(note);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public async Task DeleteNoteAsync(int id)
        {
            if (id != 0)
            {
                try
                {
                    var note = dbContext.Notes.First(x => x.Id == id);
                    dbContext.Notes.Remove(note);
                    await dbContext.SaveChangesAsync();
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }
        }
        public async Task AddToClass(ClassGroupViewModel classGroupViewModel)
        {
            if (classGroupViewModel != null)
            {
                try
                {
                    var student = dbContext.ApplicationUsers.FirstOrDefault(x => x.Id == classGroupViewModel.StudentId);
                    var classGroup = dbContext.ClassesGroup.FirstOrDefault(y => y.Id == classGroupViewModel.Id);
                    if (student != null && classGroup != null)
                    {
                        student.ClassGroup = classGroup;
                        await dbContext.SaveChangesAsync();
                    }

                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }
        }
        public List<StudentClassViewModel> GetClassById(int id)
        {
            try
            {
                var list = dbContext.ApplicationUsers.Where(x => x.ClassGroupId == id).ToList();
                var classMark = dbContext.ClassesGroup.FirstOrDefault(x => x.Id == id).ClassMark;
                var sizeGroup = dbContext.ClassesGroup.FirstOrDefault(x => x.Id == id).SizeGroup;
                var teacherId = dbContext.ClassesGroup.FirstOrDefault(x => x.Id == id).ClassTeacherId;
                var teacherEmail = dbContext.ApplicationUsers.FirstOrDefault(x => x.Id == teacherId).Email;
                List<StudentClassViewModel> studentClassViewModels = new List<StudentClassViewModel>();
                foreach (var item in list)
                {
                    StudentClassViewModel studentClassViewModel = new StudentClassViewModel();
                    studentClassViewModel.ClassMark = classMark;
                    studentClassViewModel.StudentName = item.FirstName;
                    studentClassViewModel.StudentLastName = item.LastName;
                    studentClassViewModel.SizeGroup = sizeGroup;
                    studentClassViewModel.TeacherEmail = teacherEmail;
                    studentClassViewModels.Add(studentClassViewModel);

                }
                return studentClassViewModels;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public async Task SetPresence(List<StudentPresenceViewModel> studentPresenceList)
        {
            try
            {
                var lesson = dbContext.Lessons.FirstOrDefault(x => x.Id == studentPresenceList[0].LessonId);
                foreach (var item in studentPresenceList)
                {
                    var student = dbContext.ApplicationUsers.FirstOrDefault(x => x.Id == item.StudentId);
                    if (dbContext.Presences.Any(x => x.LessonId == lesson.Id && x.StudentId == student.Id))
                    {
                        if (item.IsPresent == false)
                        {
                            var presence = dbContext.Presences.FirstOrDefault(x => x.LessonId == lesson.Id && x.StudentId == student.Id);
                            if (presence.IsPresent == true)
                            {
                                presence.IsPresent = false;
                            }
                        }
                        else
                        {
                            var presence = dbContext.Presences.FirstOrDefault(x => x.LessonId == lesson.Id && x.StudentId == student.Id);
                            if (presence.IsPresent == false)
                            {
                                presence.IsPresent = true;
                            }
                        }
                    }
                    else
                    {
                        Presence presence = new Presence()
                        {
                            IsPresent = item.IsPresent,
                            Lesson = lesson,
                            Student = student,
                        };

                        await dbContext.Presences.AddAsync(presence);
                    }
                    await dbContext.SaveChangesAsync();
                }

            }
            catch (InvalidOperationException ex)
            {

                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public async Task<List<StudentPresenceViewModel>> GetClassToSetPresence(int id)
        {
            try
            {
                var lesson = dbContext.Lessons.FirstOrDefault(x => x.Id == id);
                var subject = dbContext.Subjects.FirstOrDefault(y => y.Id == lesson.SubjectId);
                var students = dbContext.ApplicationUsers.Where(v => v.ClassGroupId == lesson.ClassGroupId).ToList();
                List<StudentPresenceViewModel> studentPresenceList = new List<StudentPresenceViewModel>();
                foreach (var item in students)
                {
                    var presence = dbContext.Presences.FirstOrDefault(x => x.StudentId == item.Id && x.LessonId == lesson.Id);

                    StudentPresenceViewModel studentPresenceViewModel = new StudentPresenceViewModel();
                    studentPresenceViewModel.StudentFirstName = item.FirstName;
                    studentPresenceViewModel.StudentLastName = item.LastName;
                    studentPresenceViewModel.Start = lesson.Start;
                    studentPresenceViewModel.End = lesson.End;
                    studentPresenceViewModel.StudentId = item.Id;
                    studentPresenceViewModel.SubjectName = subject.SubjectName;
                    studentPresenceViewModel.LessonId = lesson.Id;
                    if (presence != null)
                    {
                        if (presence.IsPresent == true)
                        {
                            studentPresenceViewModel.IsPresent = true;
                        }
                    }

                    studentPresenceList.Add(studentPresenceViewModel);

                }
                await dbContext.SaveChangesAsync();
                return studentPresenceList;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public async Task<List<ClassGroupViewModel>> ChooseLesson()
        {
            try
            {
                List<ClassGroupViewModel> classGroupViewModelList = new List<ClassGroupViewModel>();
                var list = dbContext.ClassesGroup;
                foreach (var item in list)
                {

                    ClassGroupViewModel classGroupViewModel = new ClassGroupViewModel();
                    classGroupViewModel.SizeGroup = item.SizeGroup;
                    classGroupViewModel.ClassMark = item.ClassMark;
                    classGroupViewModel.Id = item.Id;
                    classGroupViewModelList.Add(classGroupViewModel);

                }
                await dbContext.SaveChangesAsync();
                return classGroupViewModelList;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public async Task<List<LessonViewModel>> GetLesson(int id)
        {
            try
            {
                List<LessonViewModel> lessonViewModelList = new List<LessonViewModel>();
                var lessons = dbContext.Lessons.Where(x => x.ClassGroupId == id).ToList();

                foreach (var item in lessons)
                {
                    LessonViewModel lessonViewModel = new LessonViewModel();
                    var subject = dbContext.Subjects.FirstOrDefault(y => y.Id == item.SubjectId);
                    var teacher = dbContext.ApplicationUsers.FirstOrDefault(x => x.Id == subject.TeacherId);
                    lessonViewModel.Date = item.Date;
                    lessonViewModel.End = item.End;
                    lessonViewModel.Start = item.Start;
                    lessonViewModel.LessonType = item.LessonType;
                    lessonViewModel.SubjectName = subject.SubjectName;
                    lessonViewModel.ClassGroupTeacherEmail = teacher.Email;
                    lessonViewModel.Id = item.Id;
                    lessonViewModelList.Add(lessonViewModel);

                }
                await dbContext.SaveChangesAsync();
                return lessonViewModelList;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public async Task<List<ClassGroupViewModel>> GetClassGroup()
        {

            List<ClassGroupViewModel> classGroupViewModelList = new List<ClassGroupViewModel>();
            try
            {
                var classGroup = dbContext.ClassesGroup.ToList();
                foreach (var item in classGroup)
                {
                    ClassGroupViewModel classGroupViewModel = new ClassGroupViewModel();
                    var teacher = dbContext.ApplicationUsers.FirstOrDefault(x => x.Id == item.ClassTeacherId);
                    classGroupViewModel.Course = item.Course;
                    classGroupViewModel.SizeGroup = item.SizeGroup;
                    classGroupViewModel.TeacherEmail = teacher.Email;
                    classGroupViewModel.Id = item.Id;
                    classGroupViewModel.ClassMark = item.ClassMark;
                    classGroupViewModelList.Add(classGroupViewModel);
                }
                await dbContext.SaveChangesAsync();
                return classGroupViewModelList;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public async Task<UserAddressViewModel> UpdateUser(string id)
        {
            try
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
                return userAddressViewModel;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           
        }
        public  List<Subject> GetSubjectList()
        {
            try
            {
                List<SubjectViewModel> subjectViewModelList = new List<SubjectViewModel>();
                SubjectViewModel subjectViewModel = new SubjectViewModel();
                var subjects = GetSubject();
                foreach (var item in subjects)
                {
                    var teacher = dbContext.ApplicationUsers.FirstOrDefault(x => x.Id == item.TeacherId);
                    subjectViewModel.SubjectName = item.SubjectName;
                    subjectViewModel.TeacherEmail = teacher.Email;
                    subjectViewModel.TeacherId = item.TeacherId;
                    subjectViewModelList.Add(subjectViewModel);
                }
                return subjects;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
