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
        MySqlConnection connection = new MySqlConnection("DataSource=localhost;database=testlabsystem;uid=root;pwd=123456789");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
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
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn C = new SignIn();
            C.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void searchData(string valueToSearch, string valueToSearch2)
        {
             string query = "SELECT * FROM TESTS WHERE CONCAT (PatientID,ReportDate) like '%" + valueToSearch + valueToSearch2 + "%'";
            
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            if (dataGridView1.Rows.Count > 1)
             {


                MessageBox.Show("Report Date or Patient ID are valid.");
                int firstRowIndex = dataGridView1.SelectedRows.Count - 1;
                string cell = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox4.Text = cell;

            }
            else
            {
                MessageBox.Show("Report Date and Patient ID is incorrect,please try again!");
                
                PatientID.Clear();
                
                PatientID.Focus();
               


            }
        }

        




        private void button2_Click_2(object sender, EventArgs e)
        {
            string valueToSearch = PatientID.Text.ToString();
            string valueToSearch2 = dateTimePicker1.Text.ToString();

            searchData(valueToSearch, valueToSearch2);
        }
    }
}
