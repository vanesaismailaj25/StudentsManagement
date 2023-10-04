using System.ComponentModel.DataAnnotations;

namespace StudentsManagement.DTO.Student
{
    public class StudentLogin_DTO
    {
        [EmailAddress]
        [Required(ErrorMessage = "Username should not be empty!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password should not be empty!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
