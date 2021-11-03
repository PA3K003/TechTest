using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTest.Model
{
   public partial class EmployeeModel
    {  
        public int Id { get; set; }

        
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string SurName { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(13)]
        public string EmployeeNumber { get; set; }

        //[Column(TypeName = "date")]
        //[DataType(DataType =DateTime)]
        //public DateTime EmploymentDate { get; set; }

        //[Column(TypeName = "date")]
        //public DateTime? TerminatedDate { get; set; }

        public bool IsActive { get; set; }
        //[Required]
        //[StringLength(6)]
        //public string Gender { get; set; }
        //public int? Salary { get; set; }
        //[Required]
        //[StringLength(50)]
        //public string Department { get; set; }
    }
}

