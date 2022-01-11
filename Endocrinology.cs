using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Lab_System
{
    public partial class Endocrinology : Form
    {
        
        public Endocrinology(string msg1, string msg2, string msg3, string msg4, string msg5, string msg7)
        {
            InitializeComponent();
            AppDate.Text = msg1;
            ReportDate.Text = msg2;
            PhysicianName.Text = msg3;
            PatientName.Text = msg4;
            PatientID.Text = msg5;
            PatientAge.Text = msg7;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
