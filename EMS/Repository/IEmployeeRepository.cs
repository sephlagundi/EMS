using EMS.Models;

namespace EMS.Repository
{
    /*  public class IEmployeeRepository
      {
          internal object GetEmployeeById(int employeeId)
          {
              throw new NotImplementedException();
          } */

    public interface IEmployeeRepository // contract 
    {
        List<Employee> GetAllEmployees();

        // get any specific Employee
        Employee GetEmployeeById(int Id);

        // add Employee into the list
        Employee AddEmployee(Employee newEmployee);

        // update Employee in the list
        Employee UpdateEmployee(int employeeId, Employee newEmployee);

        // delete 
        Employee DeleteEmployee(int employeeId);
    }
}
