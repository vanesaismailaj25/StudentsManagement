using Microsoft.EntityFrameworkCore;
using StudentsManagement.BLL.StudentLogin.Interfaces;
using StudentsManagement.DAL.Models;
using StudentsManagement.DTO.Student;
using StudentsManagement.Helpers.DbHelpers;

namespace StudentsManagement.BLL.StudentLogin.Implementation
{
    public class StudentLoginRepository : IStudentLoginRepository
    {
        private readonly StudentsManagementContext context;

        public StudentLoginRepository(StudentsManagementContext context)
        {
            this.context = context;
        }

        public Student GetStudentByEmail(string email)
        {
            var student = context.Students.FirstOrDefault(u=>u.Email == email);
            return student;
        }

        public async Task<bool> Login(StudentLogin_DTO studentLogin)
        {
            try
            {
            var student = await context.Students.FirstOrDefaultAsync(x => x.Email == studentLogin.Email && x.Password == studentLogin.Password);
            return student != null;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
    }
}
