using EMS.Models;

namespace EMS.Repository.InMemory
{
    public class EmployeeInMemoryRepository : IEmployeeRepository
    {
        static List<Employee> employeeList = new List<Employee>();

        static EmployeeInMemoryRepository()
        {
            employeeList.Add(new Employee(1, "Joseph", DateOnly.Parse("05 Jul 1995"), "seph@gmail.com", "7391291942", 1)); ;
            employeeList.Add(new Employee(2, "Annelee", DateOnly.Parse("18 Dec 1997"), "anne@yahoo.com", "3251269971", 1 )); ;
            employeeList.Add(new Employee(3, "Stitch", DateOnly.Parse("30 Jun 2017"), "stitch@hotmail.com", "5126640098", 1 )); ;
            employeeList.Add(new Employee(4, "Chewy", DateOnly.Parse("13 Jul 2022"), "chewy@gmail.com", "315663331", 1 )); ;
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeList;
        }

        // GET ANY SPECIFIC Employee
        public Employee GetEmployeeById(int Id)
        {
            return employeeList.FirstOrDefault(x => x.Id == Id);
        }

        // ADD
        public Employee AddEmployee(Employee newEmployee)
        {
            newEmployee.Id = employeeList.Max(x => x.Id) + 1; // max id of your list
            employeeList.Add(newEmployee);
            return newEmployee;
        }

        //DELETE
        public Employee DeleteEmployee(int employeeId)
        {
            var oldEmployee = employeeList.Find(x => x.Id == employeeId);
            if (oldEmployee == null)
                return null;
            employeeList.Remove(oldEmployee);
            return oldEmployee;
        }

        // update todo in the list
        public Employee UpdateEmployee(int employeeId, Employee newEmployee)
        {
            var oldEmployee = employeeList.Find(x => x.Id == employeeId);
            if (oldEmployee == null)
                return null;
            employeeList.Remove(oldEmployee);
            employeeList.Add(newEmployee);
            return newEmployee;
        }


    }
}
