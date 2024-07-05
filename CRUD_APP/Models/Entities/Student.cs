using System.ComponentModel.DataAnnotations;

namespace CRUD_APP.Models.Entities
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public int roll {get; set;}
    }
}
