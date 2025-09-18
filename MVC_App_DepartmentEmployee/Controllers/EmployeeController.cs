using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_App_DepartmentEmployee.core.ApplicationDbContext;
using MVC_App_DepartmentEmployee.core.entities;
using MVC_App_DepartmentEmployee.ViewModels;

namespace MVC_App_DepartmentEmployee.Controllers;

public class EmployeeController(ApplicationDbContext context) : Controller
{
    // GET
    public IActionResult Index()
    {
        var employees = context.Employees.Include(x => x.Department).ToList();
        return View(employees);
    }

    public IActionResult Create()
    {
        var department = context.Departments.ToList();

        var createViewModel = new DepartmentEmployeeViewModels();
        createViewModel.Department = department;
        
        return View(createViewModel);
    }

    [HttpPost]
    public IActionResult Create(Employee employee)
    {
        context.Add(employee);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var employee = context.Employees.Find(id);
        var department = context.Departments.ToList();
        var viewModel = new DepartmentEmployeeViewModels
        {
            Employee = employee,
            Department = department
        };
        return View(viewModel);
    }

    [HttpPost]
    public IActionResult Edit(Employee employee)
    {
        context.Update(employee);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult Delete(int id)
    {
        var employee = context.Employees.Find(id);
        if (employee != null)
        {
            context.Employees.Remove(employee);
            context.SaveChanges();
        }
        return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult Details(int id)
    {
        var employee = context.Employees
            .Include(x => x.Department)
            .FirstOrDefault(x => x.EmployeeId == id);
        return View(employee);
        
    }
}