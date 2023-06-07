using System.ComponentModel.DataAnnotations;

namespace FirstAPIAssignmentRepo.Model
{
    public class EmployeeRequest
    {
        [StringLength(30, MinimumLength = 3, ErrorMessage = "FullName should be maximum 30 length")]
        public string FullName { get; set; }        
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }

        [Range(21, 100,ErrorMessage = "Please enter age between 21 to 100")]
        public int Age { get; set; }
        public string Designation { get; set; }        
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        public string Email { get; set; }
    }
}
