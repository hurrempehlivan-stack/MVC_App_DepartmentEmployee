namespace MVC_App_DepartmentEmployee.core.entities;

public class Employee
{
    public int  EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public int EmployeeAge  { get; set; }
    public string EmployeeAdress  { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
}