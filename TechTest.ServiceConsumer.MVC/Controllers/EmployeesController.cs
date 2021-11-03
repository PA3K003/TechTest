using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TechTest.Model;
using TechTest.ServiceConsumer.MVC.ServiceEmployRef;

namespace TechTest.ServiceConsumer.MVC.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeeServiceClient db = new EmployeeServiceClient();

      

        // GET: Employees
        public ActionResult Index()
        {
            return View(db.GetEmployees(GetEmployees().ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int  id)
        {
            var employee = db.EmployeeFindById(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,SurName,DateOfBirth,EmployeeNumber,IsActive")] EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeCreate(employee);
                
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            //    if (id == null)
            //    {
            //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //    }
            var employee = db.EmployeeFindById(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,SurName,DateOfBirth,EmployeeNumber,IsActive")] EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeUpdate(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
             
            EmployeeModel employee = db.EmployeeFindById(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
           db.DeleteEmployee(id);
         
            return RedirectToAction("Index");
        }

        
    }
}
