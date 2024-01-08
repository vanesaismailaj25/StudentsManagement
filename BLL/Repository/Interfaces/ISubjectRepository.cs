using StudentsManagement.DAL.Models;
using StudentsManagement.DTO.Subject;

namespace StudentsManagement.BLL.Repository.Interfaces;
public interface ISubjectRepository
{
    Task<IEnumerable<Subject>> GetAllSubjectsAsync();
    Task<Subject> CreateSubjectAsync(Subject_DTO subject);
    Task<string> UpdateSubjectAsync(Subject_DTO subject);
    Task<Subject_DTO> DeleteSubjectAsync(Subject_DTO subject);
}
