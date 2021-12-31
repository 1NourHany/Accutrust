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
        public string PAT_PHONE { get; set; }
        [Required(ErrorMessage = "ID is required")]
        public string PatientID { get; set; }
        [StringLength(10)]
        public string PatientFirstName { get; set; }
        [StringLength(10)]
        public string PatientLastName { get; set; }
        public string PatientAge { get; set; }
        [StringLength(10)]
        public string PatientGender { get; set; }
        [RegularExpression("(201)[0-9]{9}")]
        public string PatientMobilePhone { get; set; }
        [Required]
        [RegularExpression("^([1-9]{1}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[0-9]{2}[0-9]{5})$", ErrorMessage = "Please enter a valid Natinal ID")]
        public string PatientNationalID { get; set; }
        [StringLength(30)]
        public string PatientAddress { get; set; }
        [StringLength(10)]
        public string PatientMaritalStatus { get; set; }
        [StringLength(3)]
        public string PatientBloodType { get; set; }
        [StringLength(15)]
        public string PatientNationality { get; set; }
        [StringLength(50)]
        public string PatientEmail { get; set; }
        public string PatientDOB { get; set; }
        [StringLength(10)]
        public string PatientJob { get; set; }
        [StringLength(10)]
        public string PatientMotherName { get; set; }
        [StringLength(10)]
        public string InsuranceCompany { get; set; }
        [StringLength(10)]
        public string InsuranceAddress { get; set; }
        [RegularExpression("(201)[0-9]{9}")]
        public string InsurancePhone { get; set; }
        [StringLength(10)]
        public string InsuranceSubscriberName { get; set; }
        [RegularExpression("(201)[0-9]{9}")]
        public string PatientHomePhone { get; set; }
        [StringLength(10)]
        public string EmergencyContactName { get; set; }
        [RegularExpression("(201)[0-9]{9}")]
        public string EmergencyContactMobile { get; set; }
        [StringLength(10)]
        public string EmergencyContactRelationship { get; set; }

    }
}
