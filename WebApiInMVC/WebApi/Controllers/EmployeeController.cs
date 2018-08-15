using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.BusinessLayer;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class EmployeeController : ApiController
    {

        private IEmployeeBusinessLayer _objEmployeeBal;
        public EmployeeController(IEmployeeBusinessLayer objSchoolBal)
        {
            _objEmployeeBal = objSchoolBal;
        }

        //private DBModel db = new DBModel();

        // GET api/Employee
        [ActionName("DefaultAction")]
        public IQueryable<Employee> GetEmployees()
        {
            //return db.Employees;
            return _objEmployeeBal.GetEmployeeInformation();
        }

        // GET api/Employee/5
        [ResponseType(typeof(Employee))]
        public IHttpActionResult GetEmployee(int id)
        {
            Employee employee = _objEmployeeBal.GetEmployeeWithID(id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // PUT api/Employee/5
        public IHttpActionResult PutEmployee(int id, Employee employee)
        {
            _objEmployeeBal.PutEmployee(employee);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/Employee
        [ResponseType(typeof(Employee))]
        public IHttpActionResult PostEmployee(Employee employee)
        {

            Employee employeeRet = _objEmployeeBal.PostEmployee(employee);

            return CreatedAtRoute("DefaultApi", new { id = employeeRet.EmployeeID }, employeeRet);
        }

        // DELETE api/Employee/5
        [ResponseType(typeof(Employee))]
        public IHttpActionResult DeleteEmployee(int id)
        {
            Employee employeeRet = _objEmployeeBal.DeleteEmployee(id);
            return Ok(employeeRet);
        }
       
    }
}