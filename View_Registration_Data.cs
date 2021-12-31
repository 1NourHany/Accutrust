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
    public partial class View_Registration_Data : Form
    {
        public View_Registration_Data()
        {
            InitializeComponent();
        }        
        MySqlConnection connection = new MySqlConnection("DataSource=localhost;database=testlabsystem;uid=root;pwd=123456789");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;

        private void View_Registration_Data_Load(object sender, EventArgs e)
        {
            searchRegistration();
            searchAppointment();
            searchTests();
            clean();
        }
        public void clean()
        {
            dataGridView1.DataSource = null;

        }

        public void searchRegistration()
        {
            string query = "SELECT * FROM REGISTRATION";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public void searchAppointment()
        {
            string query2 = "SELECT * FROM APPOINTMENT";
            command = new MySqlCommand(query2, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public void searchTests()
        {
            string query3 = "SELECT * FROM TESTS";
            command = new MySqlCommand(query3, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void SEARCH_REGISTRATION_Click(object sender, EventArgs e)
        {
            searchRegistration();
        }
        private void SEARCH_Appoitnment_Click(object sender, EventArgs e)
        {
            searchAppointment();
        }
        private void SEARCH_Tests_Click(object sender, EventArgs e)
        {
            searchTests();
        }



        private void clickMenu(object sender, EventArgs e)
        {
            this.Hide();
            Registrar__Navigation_Screen f2 = new Registrar__Navigation_Screen();
            f2.Show();
        }
    }
}
