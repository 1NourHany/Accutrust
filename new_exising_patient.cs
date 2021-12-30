using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Lab_System
{
    public partial class new_exising_patient : Form
    {
        //bool flag = false;
        MySqlConnection connection = new MySqlConnection("DataSource=localhost;database=testlabsystem;uid=root;pwd=123456789");
        MySqlCommand command;        
        MySqlDataAdapter adapter;
        DataTable table;
        public new_exising_patient()
        {
            InitializeComponent();
        }
        private void Csharp_MySQL_Datagridview_Search_Load(object sender, EventArgs e)
        {
            searchData("");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            AddAppointment f2 = new AddAppointment();
            f2.Show();
        }
        public void searchData(string valueToSearch)
        {
            string query = "SELECT * FROM REGISTRATION WHERE CONCAT(PatientID) like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            
            if(dataGridView1.Rows.Count >1)
            {
               MessageBox.Show("Patient ID is found");

            }
            else
            {
                MessageBox.Show("Cannot find Patient ID");
                this.Hide();
                patient f4 = new patient();
                f4.Show();
            }
        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            string valueToSearch = textBox1.Text.ToString();
            searchData(valueToSearch);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient f1 = new patient();
            f1.Show();
        }
        private void menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrar__Navigation_Screen f5 = new Registrar__Navigation_Screen();
            f5.Show();
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_exising_patient_Load(object sender, EventArgs e)
        {

        }
    }
}

