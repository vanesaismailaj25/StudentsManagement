using StudentsManagement.DAL.Enums;

namespace StudentsManagement.DAL.Models;
public class Student : Base
{
    public string LastName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public int StudentYear { get; set; } 
    public DateTime RegistrationYear { get; set; }
    public string Password { get; set; } = null!;
    public ICollection<SubjectStudents> SubjectStudents { get; set; }
}