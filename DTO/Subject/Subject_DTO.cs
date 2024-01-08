using System.ComponentModel.DataAnnotations;

namespace StudentsManagement.DTO.Subject;

public class Subject_DTO
{
    [Required]
    [MaxLength(10)]
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    [MaxLength(2)]
    public int Credits { get; set; }
}
