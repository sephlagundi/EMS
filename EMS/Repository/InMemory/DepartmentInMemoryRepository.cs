using EMS.Models;


namespace EMS.Repository.InMemory
{
    public class DepartmentInMemoryRepository : IDepartmentRepository
    {
        static List<Department> departmentList = new List<Department>();

        static DepartmentInMemoryRepository()
        {
            departmentList.Add(new Department(1, "IT"));
            departmentList.Add(new Department(2, "Payroll"));
            departmentList.Add(new Department(3, "HR"));
        }
        public List<Department> GetAllDepartments()
        {
            return departmentList;
        }

        // ADD DEPT INTO THE LIST
        public Department AddDepartment(Department newDepartment)
        {
            newDepartment.DepartmentId = departmentList.Max(x => x.DepartmentId) + 1; // max id of your list
            departmentList.Add(newDepartment);
            return newDepartment;
        }

        // GET ANY DEPARTMENT
        public Department GetDepartmentById(int Id)
        {
            return departmentList.FirstOrDefault(x => x.DepartmentId == Id);
        }

        // EDIT
        public Department UpdateDepartment(int departmentId, Department newDepartment)
        {
            var oldDepartment = departmentList.Find(x => x.DepartmentId == departmentId);
            if (oldDepartment == null)
                return null;
            departmentList.Remove(oldDepartment);
            departmentList.Add(newDepartment);
            return newDepartment;
        }

        // DELETE
        public Department DeleteDepartment(int departmentId)
        {
            var oldDepartment = departmentList.Find(x => x.DepartmentId == departmentId);
            if (oldDepartment == null)
                return null;
            departmentList.Remove(oldDepartment);
            return oldDepartment;
        }


    }
}
