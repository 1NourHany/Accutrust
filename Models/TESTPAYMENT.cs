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

namespace Test_Lab_System
{
    internal class TESTPAYMENT : TESTS
    {
        [Required]
        public string TransactionNumber { get; set; }
        [Required]
        public string TotalPayment { get; set; }
    }
}

