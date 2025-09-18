using Microsoft.AspNetCore.Mvc;
using MVC_App_DepartmentEmployee.core.ApplicationDbContext;
using MVC_App_DepartmentEmployee.core.entities;

namespace MVC_App_DepartmentEmployee.Controllers;

public class DepartmentController(ApplicationDbContext context): Controller
{
    // GET
    public IActionResult Index()
    {
        var departments=context.Departments.ToList();
        return View(departments);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Department department)
    {
        context.Departments.Add(department);
        context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        var department=context.Departments.Find(id);
        if(department!=null)
        {
            context.Departments.Remove(department); 
            context.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var department=context.Departments.Find(id);
        return View(department);
    }
    [HttpPost]
    public IActionResult Edit(Department department)
    { 
        context.Departments.Update(department);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult Details(int id)
    {
        var department=context.Departments.Find(id);
        return View(department);
    }
}
