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
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void AdminView_Load(object sender, EventArgs e)
        {

        }

        private void AddPatient_CLick(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();
            Registrar__Navigation_Screen f1 = new Registrar__Navigation_Screen();
            f1.Show();
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();
            AddEmployee f3 = new AddEmployee();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
