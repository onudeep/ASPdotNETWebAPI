using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPdotNETWebAPI.Models
{
    public class Employees
    {
        [Required]
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public int DepartmentID { get; set; } //Foreign Key  
        public Department Department { get; set; } //Navigation Property  

    }
}