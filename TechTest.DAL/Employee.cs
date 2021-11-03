namespace TechTest.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

 
    public partial class Employee
    {
        public int Id { get; set; }
        
        public string Name { get; set; } 
        public string SurName { get; set; }

        public DateTime DateOfBirth { get; set; }

  
        public string EmployeeNumber { get; set; }

      

        public bool IsActive { get; set; }
        
       
    }
}
