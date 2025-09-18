using MVC_App_DepartmentEmployee.core.entities;

namespace MVC_App_DepartmentEmployee.ViewModels;

public class DepartmentEmployeeViewModels
{
    public Employee Employee { get; set; }
    public List<Department> Department { get; set; }
    public Department Departments { get; set; }
}