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
    internal class Appointments : REGISTRATION
    {
        [Required]
        public string AppointmentID { get; set; }
        [Required]
        public string AppointmentDate { get; set; }
        [Required]
        public string Appointmenttime { get; set; }
    }
}

