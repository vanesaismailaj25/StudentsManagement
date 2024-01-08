namespace StudentsManagement.DAL.Models;
public class Subject : Base
{
    public int Credits { get; set; }
    public ICollection<SubjectStudents> SubjectStudents { get; set; }
}