namespace MVC_App_DepartmentEmployee.core.entities;

public class Department
{
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public string DepartmentDescription { get; set; }
    public List<Employee> Employees { get; set; }
}