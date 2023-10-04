using StudentsManagement.DAL.Models;
using StudentsManagement.DTO.Student;

namespace StudentsManagement.BLL.StudentLogin.Interfaces
{
    public interface IStudentLoginRepository
    {
        public Student GetStudentByEmail(string email);
        public Task<bool> Login(StudentLogin_DTO studentLogin);
    }
}
