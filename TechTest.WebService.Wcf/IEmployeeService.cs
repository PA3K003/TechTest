using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TechTest.Model;

namespace TechTest.WebService.Wcf
{
    // NOTE: You can use the "Rename" command on the                                                                                                                                                            "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {

        [OperationContract]
        void DeleteEmployee(int id);

        [OperationContract] 
        EmployeeModel EmployeeCreate(EmployeeModel employee);

        [OperationContract]
        EmployeeModel EmployeeUpdate(EmployeeModel employee);

        [OperationContract]
        IList<EmployeeModel> GetEmployees();

        [OperationContract] 
         EmployeeModel EmployeeFindById(int id);


        // TODO: Add your service operations here
    }


  
}
