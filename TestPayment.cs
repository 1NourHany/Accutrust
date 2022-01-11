using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Configuration;
using System.ComponentModel.DataAnnotations;
namespace Test_Lab_System
{
    public partial class TestPayment : Form
    {
        public TestPayment()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TestPayment_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         //this.Hide();
         //CBCtest C = new CBCtest(AppDate.Text, ReportDate.Text, PhysicianName.Text, PatientName.Text, PatientID.Text, PatientAge.Text);
         //C.Show();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn C = new SignIn();
            C.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TESTPAYMENT testpayment = new TESTPAYMENT();
            testpayment.TestName = textBox1.Text;
            //testpayment.TransactionNumber = PatientID.Text;
            testpayment.PatientID = PatientID.Text;
            testpayment.TotalPayment = Address.Text;
            MySqlConnection conn = new MySqlConnection("server=localhost;database=testlabsystem;uid=root;pwd=123456789");
            MySqlCommand cmd = null;
            //string cmdString = "";
            conn.Open();
            string cmdString = ";";
           
            cmd = new MySqlCommand(cmdString, conn);

            cmd.Parameters.Add("@param1", MySqlDbType.VarChar);
            cmd.Parameters["@param1"].Value = Registration.TransactionNumber.ToString();
            cmd.Parameters.Add("@param2", MySqlDbType.VarChar);
            cmd.Parameters["@param2"].Value = Registration.TotalPayment.ToString(); ;
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.InsertCommand = cmd;
            adp.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Data Stored Successfully");

            AddAppointment obj = new AddAppointment(textBox1.Text);
            obj.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
