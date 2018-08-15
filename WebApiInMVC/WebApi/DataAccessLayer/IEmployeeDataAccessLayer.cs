using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.DataAccessLayer
{
    public interface IEmployeeDataAccessLayer
    {
        IQueryable<Employee> GetEmployeeInformation();
        Employee GetEmployeeWithID(int id);

        Employee PostEmployee(Employee employee);

        Employee DeleteEmployee(int id);

        void PutEmployee(Employee employee);
    }
}
