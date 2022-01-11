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

namespace Test_Lab_System
{
    public partial class DoctorView : Form
    {
        MySqlConnection connection = new MySqlConnection("DataSource=localhost;database=testlabsystem;uid=root;pwd=123456789");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        MySqlConnection connection2 = new MySqlConnection("DataSource=localhost;database=testlabsystem;uid=root;pwd=123456789");
        MySqlCommand command2;
        MySqlDataAdapter adapter2;
        DataTable table2;
        public DoctorView()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //this.Hide();
            // AddAppointment f2 = new AddAppointment();
            //f2.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            CBCtest obj = new CBCtest(AppDate.Text, ReportDate.Text, PhysicianName.Text, PatientName.Text, PatientID.Text, PatientAge.Text);
            obj.Show();
        }

        private void DoctorView_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhysicianName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Endocrinology obj2 = new Endocrinology(AppDate.Text, ReportDate.Text, PhysicianName.Text, PatientName.Text, PatientID.Text, PatientAge.Text);
            obj2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorView t = new DoctorView();
            t.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void searchData(string valueToSearch,  string valueToSearch2, string valueToSearch3, string valueToSearch4)
        {
            string query = "SELECT * FROM APPOINTMENT WHERE CONCAT (AppointmentDate,PatientID) like '%" + valueToSearch + valueToSearch2+ "%'";

            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            string query2 = "SELECT * FROM REGISTRATION WHERE CONCAT (PatientFirstName,PatientAge,PatientID) like '%" + valueToSearch3 + valueToSearch4 + valueToSearch2 + "%'";
            command2 = new MySqlCommand(query2, connection2);
            adapter2 = new MySqlDataAdapter(command2);
            table2 = new DataTable();
            adapter2.Fill(table2);
            dataGridView2.DataSource = table2;
            if (dataGridView1.Rows.Count > 1)
            {
                if (dataGridView2.Rows.Count > 1)
                {
                    

                    MessageBox.Show("Appointment Date, Patient ID, PatientName and PatientAge are valid.");



                }
            }
            else
            {
                MessageBox.Show("Appointment Date, Patient ID, PatientName or PatientAge is incorrect,please try again!");
                PhysicianName.Clear();
                PatientName.Clear();
                PatientID.Clear();
                PatientAge.Clear();
                PhysicianName.Focus();
                PatientName.Focus();
                PatientID.Focus();
                PatientAge.Focus();


            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string valueToSearch = AppDate.Text.ToString();
            string valueToSearch2 = PatientID.Text.ToString();
            string valueToSearch3= PatientName.Text.ToString();
            string valueToSearch4 = PatientAge.Text.ToString();
            searchData(valueToSearch, valueToSearch2, valueToSearch3, valueToSearch4);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
             label5.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();


        }

        private void AppDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TestsNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBCTest_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void check()
        {
            if (CBCTest.Checked && !Endocrinology.Checked)
            {
                int firstRowIndex = dataGridView1.SelectedRows.Count - 1;
                string cell = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TESTS tests = new TESTS();
                tests.TestName = "CBC";
                tests.AppointmentID = cell;
                MySqlConnection conn = new MySqlConnection("server=localhost;database=testlabsystem;uid=root;pwd=123456789");
                MySqlCommand cmd = null;
                conn.Open();
                string cmdString = "insert into TESTS(TestName,AppointmentID) values(@param2 , @param1);";
                cmd = new MySqlCommand(cmdString, conn);

                cmd.Parameters.Add("@param1", MySqlDbType.VarChar);
                cmd.Parameters["@param1"].Value = tests.AppointmentID.ToString();
                cmd.Parameters.Add("@param2", MySqlDbType.VarChar);
                cmd.Parameters["@param2"].Value = tests.TestName.ToString();

                MySqlDataAdapter adp = new MySqlDataAdapter();
                adp.InsertCommand = cmd;
                adp.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Data Stored Successfully");


            }
            if (!CBCTest.Checked && Endocrinology.Checked)
            {
                int firstRowIndex = dataGridView1.SelectedRows.Count - 1;
                string cell = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TESTS tests = new TESTS(); 
                tests.TestName = "Endocrinology";
                tests.AppointmentID = cell;
                MySqlConnection conn = new MySqlConnection("server=localhost;database=testlabsystem;uid=root;pwd=123456789");
                MySqlCommand cmd = null;
                conn.Open();
                string cmdString = "insert into TESTS(TestName,AppointmentID) values(@param2 , @param1);";
                cmd = new MySqlCommand(cmdString, conn);

                cmd.Parameters.Add("@param1", MySqlDbType.VarChar);
                cmd.Parameters["@param1"].Value = tests.AppointmentID.ToString();
                cmd.Parameters.Add("@param2", MySqlDbType.VarChar);
                cmd.Parameters["@param2"].Value = tests.TestName.ToString();

                MySqlDataAdapter adp = new MySqlDataAdapter();
                adp.InsertCommand = cmd;
                adp.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Data Stored Successfully");

            }
            else if (CBCTest.Checked && Endocrinology.Checked)
            {
                //int firstRowIndex = dataGridView1.SelectedRows.Count - 1;
                string cell = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TESTS tests = new TESTS();
                tests.TestName = "CBC and Endocrinology";
                tests.AppointmentID = cell;
                MySqlConnection conn = new MySqlConnection("server=localhost;database=testlabsystem;uid=root;pwd=123456789");
                MySqlCommand cmd = null;
                conn.Open();
                string cmdString = "insert into TESTS(TestName,AppointmentID) values(@param2 , @param1);";
                cmd = new MySqlCommand(cmdString, conn);

                cmd.Parameters.Add("@param1", MySqlDbType.VarChar);
                cmd.Parameters["@param1"].Value = tests.AppointmentID.ToString();
                cmd.Parameters.Add("@param2", MySqlDbType.VarChar);
                cmd.Parameters["@param2"].Value = tests.TestName.ToString();

                MySqlDataAdapter adp = new MySqlDataAdapter();
                adp.InsertCommand = cmd;
                adp.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Data Stored Successfully");

            }
}

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            check();
        }
    }
}

