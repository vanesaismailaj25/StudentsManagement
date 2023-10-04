using StudentsManagement.DAL.Models;
using StudentsManagement.DTO.Student;

namespace StudentsManagement.BLL.Repository.Interfaces
{
    public interface IStudentRepository
    {
        bool GetStudentByPhoneNumber(string phoneNumber);
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Student CreateStudent(Student_DTO student);
        Task<string> UpdateStudentAsync(Student_DTO student);
        Task<Student_DTO> DeleteStudentAsync(Student_DTO student);
        Task<Student_DTO> FindAsync(string phoneNumber);
    }
}
