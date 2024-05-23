using StudentsManagement.DAL.Models;
using Microsoft.AspNetCore.Components;
using StudentsManagement.BLL.Repository.Interfaces;

namespace StudentsManagement.Shared.Grids.Dashboard;

public partial class Grid_CoursesConsole
{
    //here we don't need to add,modify or delete any of the courses in the users page
    [Inject] ISubjectRepository subjectRepository { get; set; } = null!;
    private IEnumerable<Subject>? Data { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Data = await subjectRepository.GetAllSubjectsAsync();
    }
}
