using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using TechTest.BLL;
using TechTest.DAL;
using TechTest.Model;

namespace TechTest.Webservice.Controllers
{
    [RoutePrefix("api/Employees")]
    public class EmployeesController : ApiController
    {
        private IEmployeeManger _dbo ;

        private readonly IMapper mapper;       
        public EmployeesController(IMapper mapper)
        {
            this.mapper = mapper;
            this._dbo = new EmployeeManger();
        }

        public EmployeesController(IEmployeeManger dbo)
        {
            _dbo = dbo;
        }

        // GET: api/Employees
        [HttpGet()]
        [Route("All")]
        [ResponseType(typeof(IList<EmployeeModel>))]
        public IList<EmployeeModel> GetAll()
        {
            List<EmployeeModel> list = mapper.Map<List<Employee>, List<EmployeeModel>>(_dbo.AllEmployees().ToList()); 
            return list;
        }
         
        [HttpGet()]
        [ResponseType(typeof(EmployeeModel))]
        [Route("FindById")]
        public IHttpActionResult GetFindById(int id)
        {  var employee = _dbo.FindById(id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map< Employee, EmployeeModel>(employee));
            
        }
 
        [HttpPost()]
        [ResponseType(typeof(void))]
           [Route("Update")]
        public IHttpActionResult PutUpdate(EmployeeModel employee)
        {
            if (!ModelState.IsValid || employee.Id.Equals(null) || employee.Id.Equals(0))
            {
                return BadRequest(ModelState);
            }
            try
            {// mapper.Map<Source, Dest>(source);
               var _employee = mapper.Map<EmployeeModel, Employee>(employee);
                _dbo.UpdateEmployee(_employee);
            }
            catch (DbUpdateConcurrencyException)
            {
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

       
        [HttpPost()]
        [ResponseType(typeof(EmployeeModel))]
        [Route("Create")]
        public IHttpActionResult PostCreate(EmployeeModel employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var _employee = mapper.Map<EmployeeModel, Employee>(employee);
                _dbo.CreateEmployee(_employee);
               

    }
            catch (Exception)
            {

                throw;
            }

            return CreatedAtRoute("DefaultApi", new { id = employee.Id }, employee);
        }
 
        [Route("Remove")]
        public IHttpActionResult Remove(int id)
        {
              _dbo.Delete(id);


            return StatusCode(HttpStatusCode.NoContent);
        }

            }
}