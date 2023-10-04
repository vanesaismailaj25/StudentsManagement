using StudentsManagement.DAL.Enums;
using System.ComponentModel.DataAnnotations;

namespace StudentsManagement.DTO.Student
{
    public class Student_DTO
    {
        [Required]
        [MaxLength(10)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } 

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } 

        [Required,DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]      
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } 

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; } 

        [Required]
        public int StudentYear { get; set; }

        [Required]
        public DateTime RegistrationYear { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
