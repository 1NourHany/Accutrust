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

    public partial class Registrar__Navigation_Screen : Form
    {
        public Registrar__Navigation_Screen()
        {
            InitializeComponent();
        }


        private void NewPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            new_exising_patient p = new new_exising_patient();
            p.Show();
        }
        private void Appointment_Click(object sender, EventArgs e)
        {

            this.Hide();
            AddAppointment A = new AddAppointment();
            A.Show();
        }
        private void OrderTest_Click(object sender, EventArgs e)
        {

            this.Hide();
            TestPayment t = new TestPayment();
            t.Show();
        }

        private void ViewData_Click(object sender, EventArgs e)
        {

            this.Hide();
            View_Registration_Data v = new View_Registration_Data();
            v.Show();
        }
        private void Registrar__Navigation_Screen_Load(object sender, EventArgs e)
        {

        }

        private void Registrar__Navigation_Screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
