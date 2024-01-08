using Microsoft.EntityFrameworkCore;
using StudentsManagement.DAL.Models;
using StudentsManagement.DTO.Subject;
using StudentsManagement.Helpers.Mappers;
using StudentsManagement.Helpers.DbHelpers;
using StudentsManagement.BLL.Repository.Interfaces;

namespace StudentsManagement.BLL.Repository.Implementation;

public class SubjectRepository : ISubjectRepository
{
    private readonly StudentsManagementContext context;
    public SubjectRepository(StudentsManagementContext _context)
    {
        context = _context;
    }
    public async Task<Subject> CreateSubjectAsync(Subject_DTO subjectDto)
    {
        var subject = subjectDto.As_Subject();
        var toBeCreated = await context.Subjects.AddAsync(subject);
        _ = context.SaveChangesAsync();
        return toBeCreated.Entity;
    }

    public async Task<Subject_DTO> DeleteSubjectAsync(Subject_DTO subjectDto)
    {
        var toBeDeleted = await context.Subjects.FirstOrDefaultAsync(s => s.Id == subjectDto.Id);
        context.Subjects.Remove(toBeDeleted!);
        _ = context.SaveChangesAsync();
        return null!;

    }

    public async Task<IEnumerable<Subject>> GetAllSubjectsAsync()
    {
        var allSubjects = await context.Subjects.ToListAsync();
        return allSubjects;
    }

    public async Task<string> UpdateSubjectAsync(Subject_DTO subject)
    {
        var toBeUpdated = await context.Subjects.FirstOrDefaultAsync(s=> s.Id == subject.Id);

        if(toBeUpdated is null)
            return "Subject doesn't exist!";

        toBeUpdated.As_Subject_Subject(subject);
        await context.SaveChangesAsync();

        return "";
    }
}
