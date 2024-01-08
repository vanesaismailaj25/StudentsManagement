using StudentsManagement.DAL.Models;
using StudentsManagement.DTO.Subject;

namespace StudentsManagement.Helpers.Mappers
{
    public static class SubjectsMapper
    {
        public static Subject_DTO As_Subject_DTO(this Subject subject)
        {
            return new Subject_DTO
            {
                Id = subject.Id,
                Name = subject.Name,
                Credits = subject.Credits,
            };
        }
        public static Subject As_Subject(this Subject_DTO subject_DTO)
        {
            return new Subject
            {
                Id = subject_DTO.Id,
                Name = subject_DTO.Name,
                Credits = subject_DTO.Credits,
            };
        }

        public static void As_Subject_Subject(this Subject subject, Subject_DTO subject_DTO)
        {
            subject.Id = subject_DTO.Id;
            subject.Name = subject_DTO.Name;
            subject.Credits = subject_DTO.Credits;
        }
    }
}
