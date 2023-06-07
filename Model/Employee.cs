using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstAPIAssignmentRepo.Model
{
    [Table("employee")]
    public class Employee
    {
        [Key,Required]
        public Guid Id { get; set; } = Guid.NewGuid();

        [MaxLength(30)]
        public string FullName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }

        [Range(21,100)]
        public int Age { get; set; }
        public string Designation { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
        public decimal Salary { get; set; }

        [Required]
        public string Email { get; set; }

    }
}
