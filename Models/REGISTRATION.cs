using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Test_Lab_System.Models
{
    internal class REGISTRATION
    {
   
        [Required(ErrorMessage = "ID is required")]
        public string PatientID { get; set; }
        [StringLength(10)]
        [RegularExpression(@"^([A-Z][a-z-A-z]+)$", ErrorMessage = "Please enter a valid Name")]
        public string PatientFirstName { get; set; }
        [StringLength(10)]
        [RegularExpression(@"^([A-Z][a-z-A-z]+)$", ErrorMessage = "Please enter a valid Name")]
        public string PatientLastName { get; set; }
        public string PatientAge { get; set; }
        [StringLength(10)]
        public string PatientGender { get; set; }
        [RegularExpression("(01)[0-9]{9}" , ErrorMessage = "Please enter a valid Mobile Phone")]
        [DataType(DataType.PhoneNumber)]
        public string PatientMobilePhone { get; set; }
        [Required]
        [RegularExpression("^([1-9]{1}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[0-9]{2}[0-9]{5})$", ErrorMessage = "Please enter a valid Natinal ID")]
        public string PatientNationalID { get; set; }
        [StringLength(30)]
        [Required]
        public string PatientAddress { get; set; }
        [StringLength(10)]
        [Required]
        public string PatientMaritalStatus { get; set; }
        [Required]
        public string PatientBloodType { get; set; }
        [Required]
        [StringLength(15)]
        public string PatientNationality { get; set; }
        [StringLength(50)]
        [Required]
        [RegularExpression(@"^\w+[\w-\.]+\@\w{5}\.[a-z](2,3)$", ErrorMessage = "Please enter"+"\n a valid Email")]
        public string PatientEmail { get; set; }
        [Required]
        public string PatientDOB { get; set; }
        [Required]
        [StringLength(10)]
        public string PatientJob { get; set; }
        [StringLength(10)]
        [Required]
        [RegularExpression(@"^([A-Z][a-z-A-z]+)$", ErrorMessage = "Please enter a valid Name")]
        public string PatientMotherName { get; set; }
        [StringLength(10)]
        [Required]
        public string InsuranceCompany { get; set; }
        [StringLength(10)]
        [Required]
        public string InsuranceAddress { get; set; }
        [RegularExpression("(01)[0-9]{9}")]
        [Required]
        public string InsurancePhone { get; set; }
        [StringLength(11)]
        [Required]
        [RegularExpression(@"^([A-Z][a-z-A-z]+)$", ErrorMessage = "Please enter a valid Name")]
        public string InsuranceSubscriberName { get; set; }
        [RegularExpression("(01)[0-9]{9}")]
        [Required]
        public string PatientHomePhone { get; set; }
        [StringLength(10)]
        [Required]
        [RegularExpression(@"^([A-Z][a-z-A-z]+)$", ErrorMessage = "Please enter a valid Name")]
        public string EmergencyContactName { get; set; }
        [RegularExpression("(01)[0-9]{9}")]
        [Required]
        [StringLength(11)]
        public string EmergencyContactMobile { get; set; }
        [StringLength(11)]
        [Required]
        public string EmergencyContactRelationship { get; set; }

    }
}
