using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.DataAccessLayer;
using WebApi.Models;

namespace WebApi.BusinessLayer
{
    public class EmployeeBusinessLayer : IEmployeeBusinessLayer
    {
        private IEmployeeDataAccessLayer _objEmployeeDal;
        public EmployeeBusinessLayer(IEmployeeDataAccessLayer objEmployeeDal)
        {
            _objEmployeeDal = objEmployeeDal;
        }

        public IQueryable<Employee> GetEmployeeInformation()
        {
            return _objEmployeeDal.GetEmployeeInformation();
        }

        public Employee GetEmployeeWithID(int id)
        {
            return _objEmployeeDal.GetEmployeeWithID(id);
        }

        public Employee PostEmployee(Employee employee)
        {
            return _objEmployeeDal.PostEmployee(employee);
        }

        public Employee DeleteEmployee(int id)
        {
            return _objEmployeeDal.DeleteEmployee(id);
        }

        public void PutEmployee(Employee employee)
        {
            _objEmployeeDal.PutEmployee(employee);
        }
    }
}