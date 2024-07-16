using System.ComponentModel.DataAnnotations;

namespace DotNetDay3.Models
{
    public class StudentEdit
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public bool? Status { get; set; }

        public string UserRole { get; set; } = null!;
        public string EncId { get; set; }=null!;

        public IFormFile FileUpload { get; set; } = null!;
    }
}
