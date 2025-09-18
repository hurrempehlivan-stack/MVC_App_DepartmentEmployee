using Microsoft.EntityFrameworkCore;
using MVC_App_DepartmentEmployee.core.entities;

namespace MVC_App_DepartmentEmployee.core.ApplicationDbContext;

public class ApplicationDbContext  : DbContext
{ 
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)  : base(options)
  {
    
  }  
  public DbSet<Employee> Employees { get; set; }
  public DbSet<Department> Departments { get; set; }
}