using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext _dbContext;

        public EmployeeController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            List<Employee> employees = _dbContext.Employees.ToList();
            return View(employees);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Employees.Add(employee);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            Employee employee = _dbContext.Employees.Find(id);
            if (employee == null)
            {
                return View();
            }
            return View(employee);
        }



        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View();
            }

            Employee employee = _dbContext.Employees.Find(id);
            if (employee == null)
            {
                return View();
            }
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }


        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return View();
            }

            Employee employee = _dbContext.Employees.Find(id);
            if (employee == null)
            {
                return View();
            }
            return View(employee);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            Employee employee = _dbContext.Employees.Find(id);

            if (employee != null)
            {
                _dbContext.Employees.Remove(employee);
                _dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

       
    }
}