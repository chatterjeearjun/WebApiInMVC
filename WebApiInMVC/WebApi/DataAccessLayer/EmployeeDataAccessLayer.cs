using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.DataAccessLayer
{
    public class EmployeeDataAccessLayer : IEmployeeDataAccessLayer
    {
        private DBModel db = new DBModel();

        public IQueryable<Employee> GetEmployeeInformation()
        {
            return db.Employees;
        }

        public Employee GetEmployeeWithID(int id)
        {
            return db.Employees.Find(id);
        }

        public Employee PostEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee != null)
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
            }           
            return employee;
        }

        public void PutEmployee(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}