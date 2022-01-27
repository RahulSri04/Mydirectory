using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMSDemoProject.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public string DepartmentName { get; set; }
        public DateTime? Created_On { get; set; }
    }
}
