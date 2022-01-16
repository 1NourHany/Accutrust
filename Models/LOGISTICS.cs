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
    internal class LOGISTICS
    {
        [Required]
        public string OrderID { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string PhoneNum { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string RequestDate { get; set; }
        [Required]
        public string DeliveryDate { get; set; }
        [Required]
        public string Prodcut { get; set; }
        [Required]
        public string Quantity { get; set; }
        [Required]
        public string TotalPrice { get; set; }

    }
}
