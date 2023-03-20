using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [MinLength(3)]
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public Department() { }

        public Department(int departmentId, string name)
        {
            DepartmentId = departmentId;
            Name = name;

        }
    }
}
