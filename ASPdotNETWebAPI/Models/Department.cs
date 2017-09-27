using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPdotNETWebAPI.Models
{
    public class Department
    {
        [Required]
        public int DepartmentID { get; set; }
        [Required]
        public string DepartmentName { get; set; }

    }
}