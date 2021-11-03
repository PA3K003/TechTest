using System.Collections.Generic;
using TechTest.DAL;

namespace TechTest.BLL
{
    public interface IEmployeeManger
    {
        IEnumerable<Employee> AllEmployees();
        Employee CreateEmployee(Employee employee);
        void Delete(int id);
        Employee FindById(int id);
        Employee UpdateEmployee(Employee employee);
    }
}