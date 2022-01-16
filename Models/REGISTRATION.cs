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

        [Required]
        [RegularExpression(@"(1)[0-9]{7}", ErrorMessage = "Invalid\nInput")]


        [StringLength(8)]
        public string PatientID { get; set; }
        [StringLength(20)]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Invalid\nInput")]
        public string PatientFirstName { get; set; }
        [Required]
        [StringLength(10)]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Invalid\nInput")]

        public string PatientLastName { get; set; }
        [Required]
        [StringLength(2)]
        public string PatientAge { get; set; }
        [Required]
        [StringLength(6)]
        public string PatientGender { get; set; }
        [Required]
        [RegularExpression(@"(01)[0-9]{9}", ErrorMessage = "Invalid\nInput")]
        [DataType(DataType.PhoneNumber)]
        public string PatientMobilePhone { get; set; }
        [Required]
        [RegularExpression("^([1-9]{1}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[0-9]{2}[0-9]{5})$", ErrorMessage = "Invalid\nInput")]
        public string PatientNationalID { get; set; }
        [StringLength(30)]
        [Required]
        //[RegularExpression(@"\b[A-Z]\w+", ErrorMessage = "Invalid\nInput")]
        public string PatientAddress { get; set; }
        [StringLength(7)]
        [Required]

        public string PatientMaritalStatus { get; set; }
        [Required]
        [StringLength(2)]
        public string PatientBloodType { get; set; }
        [Required]
        [StringLength(20)]
        //[RegularExpression(@"\b[A-Z]\w+", ErrorMessage = "Invalid\nInput")]

        public string PatientNationality { get; set; }
        [StringLength(50)]
        [Required]
        [RegularExpression(@"^((\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)\s*[;]{0,1}\s*)+$", ErrorMessage = "Invalid\nInput")]
        public string PatientEmail { get; set; }
        [Required]
        public string PatientDOB { get; set; }
        [Required]
        [StringLength(15)]
        [RegularExpression(@"\b[A-Z]\w+", ErrorMessage = "Invalid\nInput")]

        public string PatientJob { get; set; }
        [StringLength(20)]
        [Required]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Invalid\nInput")]
        public string PatientMotherName { get; set; }
        [StringLength(20)]
        [Required]
        //[RegularExpression(@"\b[A-Z]\w+", ErrorMessage = "Invalid\nInput")]

        public string InsuranceCompany { get; set; }
        [StringLength(30)]
        [Required]
        //[RegularExpression(@"\b[A-Z]\w+", ErrorMessage = "Invalid\nInput")]
        public string InsuranceAddress { get; set; }
        [Required]
        [RegularExpression(@"(01)[0-9]{9}", ErrorMessage = "Invalid\nInput")]
        [DataType(DataType.PhoneNumber)]
        public string InsurancePhone { get; set; }
        [StringLength(20)]
        [Required]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Invalid\nInput")]
        public string InsuranceSubscriberName { get; set; }
        [Required]
        [RegularExpression(@"(02)[0-9]{8}", ErrorMessage = "Invalid\nInput")]
        [DataType(DataType.PhoneNumber)]
        public string PatientHomePhone { get; set; }
        [StringLength(20)]
        [Required]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Invalid\nInput")]
        public string EmergencyContactName { get; set; }
        [Required]
        [RegularExpression(@"(01)[0-9]{9}", ErrorMessage = "Invalid\nInput")]
        [DataType(DataType.PhoneNumber)]
        public string EmergencyContactMobile { get; set; }
        [StringLength(30)]
        [Required]
        //[RegularExpression(@"\b[A-Z]\w+", ErrorMessage = "Invalid\nInput")]
        public string EmergencyContactRelationship { get; set; }

    }
}
