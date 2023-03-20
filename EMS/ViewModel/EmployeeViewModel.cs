using EMS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace EMS.ViewModel
{
    public class EmployeeViewModel
    {
        public Employee Employees { get; set; }

        public IEnumerable <SelectListItem> ListDepartments { get; set; }
    }
}
