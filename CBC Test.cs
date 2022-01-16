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
    public partial class CBCtest : Form
    {
        public CBCtest(string msg1, string msg2, string msg3, string msg4, string msg5, string msg7)
        {
            InitializeComponent();
            AppDate.Text = msg1;
            ReportDate.Text = msg2;
            PhysicianName.Text = msg3;
            PatientName.Text = msg4;
            PatientID.Text = msg5;
            PatientAge.Text = msg7;
        }
        MySqlConnection connection = new MySqlConnection("DataSource=localhost;database=testlabsystem;uid=root;pwd=123456789");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }
        
        private void CBCtest_Load(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            string valueToSearch1 = "CBC Test";
            string valueToSearch2 = PatientID.Text.ToString();
            string valueToSearch3 = ReportDate.Text.ToString();
            string valueToSearch4 = PatientName.Text.ToString();
            string valueToSearch5 = AppDate.Text.ToString();
            searchData(valueToSearch1, valueToSearch2, valueToSearch3, valueToSearch4, valueToSearch5);
            int firstRowIndex = dataGridView1.SelectedRows.Count - 1;
            string cell = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string[] separatingStrings = { "." };
            string[] words = cell.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            textBox1.Text = words[0];
            textBox2.Text = words[1];
            textBox3.Text = words[2];
            textBox4.Text = words[3];
            textBox5.Text = words[4];
            textBox6.Text = words[5];
            textBox7.Text = words[6];
            textBox8.Text = words[7];
            textBox9.Text = words[8];
            textBox10.Text = words[9];
            textBox11.Text = words[10];
            textBox12.Text = words[11];
            textBox13.Text = words[12];
            textBox14.Text = words[13];
            textBox15.Text = words[14];
            textBox16.Text = words[15];
            textBox17.Text = words[16];
            textBox18.Text = words[17];
            textBox19.Text = words[18];
            textBox20.Text = words[19];
            //textBox21.Text = words[20];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {
            string strIP =  textBox1.Text +'.' +textBox2.Text +'.' + textBox3.Text + "." + textBox4.Text + '.' +
                textBox5.Text + '.' + textBox6.Text + "." + textBox7.Text + '.' + textBox8.Text + '.' + textBox9.Text +
                '.' + textBox10.Text + "." + textBox11.Text + '.' +
                textBox12.Text + '.' + textBox13.Text + "." + textBox14.Text
                + '.' + textBox15.Text + '.' + textBox16.Text + "." + textBox17.Text + '.' +
                textBox18.Text + '.' + textBox19.Text + "." + textBox20.Text + '.'+textBox21.Text;
            TestResults testresults = new TestResults();
            testresults.PatientID = PatientID.Text;
            testresults.PatientFirstName = PatientName.Text;
            testresults.Results = strIP;
            testresults.AppointmentDate = AppDate.Text;
            testresults.ReportDate = ReportDate.Text;
            testresults.TestName = "CBC Test";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=testlabsystem;uid=root;pwd=123456789");
            MySqlCommand cmd = null;
            conn.Open();

            string cmdString = "insert into TESTRESULTS( TestResultsID,TestName ,PatientID, ReportDate  , PatientName, Results, " +
                "AppointmentDate) " +
                "values( TO_BASE64(RANDOM_BYTES(6)),@param2 , @param3, @param4, @param5, @param6, @param7);";
            cmd = new MySqlCommand(cmdString, conn);
            cmd.Parameters.Add("@param2", MySqlDbType.VarChar);
            cmd.Parameters["@param2"].Value = testresults.TestName.ToString();
            cmd.Parameters.Add("@param3", MySqlDbType.VarChar);
            cmd.Parameters["@param3"].Value = testresults.PatientID.ToString();
            cmd.Parameters.Add("@param4", MySqlDbType.VarChar);
            cmd.Parameters["@param4"].Value = testresults.ReportDate.ToString();
            cmd.Parameters.Add("@param5", MySqlDbType.VarChar);
            cmd.Parameters["@param5"].Value = testresults.PatientFirstName.ToString();
            cmd.Parameters.Add("@param6", MySqlDbType.VarChar);
            cmd.Parameters["@param6"].Value = testresults.Results.ToString();
            cmd.Parameters.Add("@param7", MySqlDbType.VarChar);
            cmd.Parameters["@param7"].Value = testresults.AppointmentDate.ToString();

            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.InsertCommand = cmd;
            adp.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Data Stored Successfully");
        }
        public void searchData(string valueToSearch1, string valueToSearch2, string valueToSearch3, string valueToSearch4, string valueToSearch5)
        {
            string query = "SELECT * FROM TestResults WHERE CONCAT (TestName ,PatientID, ReportDate  , " +
                "PatientName, AppointmentDate) like '%" + valueToSearch1 + valueToSearch2 + valueToSearch3 + valueToSearch4 + valueToSearch5 + "%'";

            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            if (dataGridView1.Rows.Count > 1)
            {
                MessageBox.Show("Appointment Date, Patient ID, PatientName and PatientAge are valid.");
            }
            else
            {
                MessageBox.Show("This patient has no Endocrinology report in the given date!");

            }
        }
                private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
