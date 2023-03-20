using EMS.Models;

namespace EMS.Repository
{
    public interface IDepartmentRepository
    {
        List<Department> GetAllDepartments();

        // ADD
        Department AddDepartment(Department newDepartment);

        Department GetDepartmentById(int Id);

        // update todo in the list
        Department UpdateDepartment(int departmentId, Department newDepartment);

        // delete 
        Department DeleteDepartment(int departmentId);
    }
}
