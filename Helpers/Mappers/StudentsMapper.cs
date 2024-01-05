using StudentsManagement.DAL.Models;
using StudentsManagement.DTO.Student;

namespace StudentsManagement.Helpers.Mappers;

public static class StudentsMapper
{
    public static Student_DTO AS_Students_DTO(this Student student)
    {
        return new Student_DTO
        {
            Id = student.Id,
            FirstName = student.FirstName,
            LastName = student.LastName,
            DateOfBirth = student.DateOfBirth,
            Gender = student.Gender,
            Email = student.Email,
            PhoneNumber = student.PhoneNumber,
            StudentYear = student.StudentYear,
            RegistrationYear = student.RegistrationYear,
            Password = student.Password,
        };
    }

    public static Student As_Student(this Student_DTO student_DTO)
    {
        return new Student
        {
            Id = student_DTO.Id,
            FirstName = student_DTO.FirstName,
            LastName = student_DTO.LastName,
            DateOfBirth = student_DTO.DateOfBirth,
            Gender = student_DTO.Gender,
            Email = student_DTO.Email,
            PhoneNumber = student_DTO.PhoneNumber,
            StudentYear = student_DTO.StudentYear,
            RegistrationYear = student_DTO.RegistrationYear,
            Password = student_DTO.Password,
        };
    }

    public static StudentLogin_DTO As_StudentLogin_DTO(this Student login)
    {
        return new StudentLogin_DTO
        {
            Email = login.Email,
            Password = login.Password,
        };
    }

    public static void As_Student_Student(this Student student, Student_DTO studentDto)
    {
        student.DateOfBirth = studentDto.DateOfBirth;
        student.PhoneNumber = studentDto.PhoneNumber;
        student.FirstName = studentDto.FirstName;
        student.LastName = studentDto.LastName;
        student.Gender = studentDto.Gender;
        student.Email = studentDto.Email;
        student.StudentYear = studentDto.StudentYear;
        student.RegistrationYear = studentDto.RegistrationYear;
        student.Password = studentDto.Password;
    }
}