using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Lab_System.Models;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.ComponentModel.DataAnnotations;

namespace Test_Lab_System.Models
{
    internal class Employee
    { 
        //[Required(ErrorMessage = "ID is required")]
        public string EmployeeID { get; set; }
        //[StringLength(10)]
        //[RegularExpression(@"^([A-Z][a-z-A-z]+)$", ErrorMessage = "Please enter a valid Name")]
        public string EmployeeName { get; set; }
        public string EmployeeAge { get; set; }
        //[StringLength(10)]
        public string EmployeeGender { get; set; }
        //[RegularExpression("(01)[0-9]{9}", ErrorMessage = "Please enter a valid Mobile Phone")]
        [DataType(DataType.PhoneNumber)]
        public string EmployeePhone { get; set; }
        [Required]
        //[RegularExpression("^([1-9]{1}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[0-9]{2}[0-9]{5})$", ErrorMessage = "Please enter a valid Natinal ID")]
        public string EmployeeNationalID { get; set; }
        //[StringLength(10)]
        [Required]
        public string EmployeeMaritalStatus { get; set; }
        [Required]
        public string EmployeeSupervisor { get; set; }
        [Required]
        public string EmployeeNationality { get; set; }
       // [StringLength(50)]
        [Required]
       // [RegularExpression(@"^\w+[\w-\.]+\@\w{5}\.[a-z](2,3)$", ErrorMessage = "Please enter" + "\n a valid Email")]
        public string EmployeeEmail { get; set; }
        [Required]
        public string EmployeeDB { get; set; }

        //[StringLength(10)]
        [Required]
        public string EmployeeSalary { get; set; }
        [Required]

        public string EmployeePassword { get; set; }
        [Required]
        public string EmployeePosition { get; set; }
        [Required]
        public string EmployeeDepartment { get; set; }

    }
}
