using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TechTest.BLL;
using TechTest.DAL;
using TechTest.Model;

namespace TechTest.WebService.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeManger _dbo;
        private readonly IMapper Mapper;
        
        public EmployeeService(IMapper mapper)
        {
            this.Mapper = mapper;
            _dbo = new EmployeeManger();
        }

        public EmployeeService(IEmployeeManger dbo)
        {
            _dbo = dbo;
        }

        /// <summary>
        /// GetEmployees
        /// </summary>
        /// <returns>List<EmployeeModel> </returns>
        public IList<EmployeeModel> GetEmployees()
        {
            try
            {
                List<Employee> source = _dbo.AllEmployees().ToList();
                List<EmployeeModel> list = Mapper.Map<List<Employee>,List<EmployeeModel>> (source); 
                return list;
            }
            catch(Exception ex )
            {
                var err = ex.Message;
            
            }
            return null;
        }


        /// <summary>
        ///  Find Employee By Id 
        /// </summary>
        /// <param name="id">Employee id</param>
        /// <returns>EmployeeModel</returns>
        public EmployeeModel EmployeeFindById(int id)
        {
            try
            {
                var employee = _dbo.FindById(id);

            return (Mapper.Map<Employee, EmployeeModel>(employee));
        }
            catch(Exception ex )
            {
                var err = ex.Message;

    }
            return null;
        }

        /// <summary>
        /// Employee Update
        /// </summary>
        /// <param name="employee">EmployeeModel</param>
        /// <returns>EmployeeModel</returns>
        public EmployeeModel EmployeeUpdate(EmployeeModel employee)
        {

            try
            {// mapper.Map<Source, Dest>(source);
                var _employee =     Mapper.Map<EmployeeModel, Employee>(employee);
                _employee = _dbo.UpdateEmployee(_employee);

                return Mapper.Map<Employee, EmployeeModel>(_employee);
            }
            catch (DbUpdateConcurrencyException)
            {
            }

            return employee;
        }
        /// <summary>
        /// Employee Create
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public EmployeeModel EmployeeCreate(EmployeeModel employee)
        {


            try
            {
                var _employee = Mapper.Map<EmployeeModel, Employee>(employee);
                _employee = _dbo.CreateEmployee(_employee);

                return Mapper.Map<Employee, EmployeeModel>(_employee);
            }
            catch (DbUpdateConcurrencyException)
            {
            }

            return employee;
        }

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <param name="id">Employee Id</param>
        public void DeleteEmployee(int id)
        {
            try
            {

                _dbo.Delete(id);
}
            catch(Exception ex )
            {
                var err = ex.Message;
            
            }
          

        }

    }
}
