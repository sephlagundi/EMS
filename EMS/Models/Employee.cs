using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }
        [MinLength(3)]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [NotMapped]
        public DateOnly DOB { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Dept is required")]

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }


        public Employee () { }

        public Employee(int id, string name, DateOnly dOB, string email, string phone, int departmentId)
        {
            Id = id;
            Name = name;
            DOB = dOB;
            Email = email;
            Phone = phone;


        }
    }
    }

