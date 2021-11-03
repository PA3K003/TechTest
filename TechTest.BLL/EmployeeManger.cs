using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest.DAL;
using TechTest.DbAdaptor;

namespace TechTest.BLL
{
    public class EmployeeManger : IEmployeeManger
    {
        private IGenericRepository<Employee> _ctx = null;
        public EmployeeManger() => this._ctx = new GenericRepository<Employee>();
        public EmployeeManger(IGenericRepository<Employee> repository) => this._ctx = repository;
        public IEnumerable<Employee> AllEmployees()=> _ctx.GetAll().ToList();
        public Employee CreateEmployee(Employee employee) => _ctx.Insert(employee);     
        public Employee FindById(int id) => _ctx.GetById(id);
        public Employee UpdateEmployee(Employee employee) => _ctx.Update(employee);
        public void Delete(int id)
        {
            //Employee employee = FindById(id);
          
            _ctx.Delete(id);
        }
    }
}
