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
    public partial class View_Results : Form
    {
        public View_Results()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Endocrinology obj2 = new Endocrinology(AppDate.Text, ReportDate.Text, PhysicianName.Text, PatientName.Text, PatientID.Text, PatientAge.Text);
            obj2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CBCtest obj2 = new CBCtest(AppDate.Text, ReportDate.Text, PhysicianName.Text, PatientName.Text, PatientID.Text, PatientAge.Text);
            obj2.Show();
        }
    }
}
