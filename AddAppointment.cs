using System;
using Test_Lab_System.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;
namespace Test_Lab_System
{

    public partial class AddAppointment : System.Windows.Forms.Form
    {
        MySqlConnection connection = new MySqlConnection("DataSource=localhost;database=TestLabSystem;uid=root;pwd=123456789");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        //public static string textpassedForm2;
        public AddAppointment(string msg)
        {
            InitializeComponent();
            textBox2.Text = msg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime myVacation1 = new DateTime(2021, 12, 16);
            DateTime myVacation2 = new DateTime(2021, 12, 17);

            monthCalendar1.AddBoldedDate(myVacation1);
            monthCalendar1.AddBoldedDate(myVacation2);
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Tuesday;
            this.monthCalendar1.MaxDate = new System.DateTime(2028, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 20;
            this.monthCalendar1.ShowToday = true;
            this.monthCalendar1.ShowTodayCircle = true;
            this.monthCalendar1.ShowWeekNumbers = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {

            Appointments appointments = new Appointments();
            appointments.AppointmentDate = dateTimePicker1.Text;
            appointments.Appointmenttime = dateTimePicker2.Text;
            appointments.PatientID = textBox2.Text;
            MySqlConnection conn = new MySqlConnection("server=localhost;database=TestLabSystem;uid=root;pwd=123456789");
            MySqlCommand cmd = null;
            
            //string cmdString = "";
            conn.Open();
            

            string cmdString = "insert into APPOINTMENT(AppointmentID, AppointmentDate, Appointmenttime, PatientID)values(TO_BASE64(RANDOM_BYTES(5)), @param2 , @param3  , @param4);";

            cmd = new MySqlCommand(cmdString, conn);

            cmd.Parameters.Add("@param2", MySqlDbType.VarChar);
            cmd.Parameters["@param2"].Value = appointments.AppointmentDate.ToString();
            cmd.Parameters.Add("@param3", MySqlDbType.VarChar);
            cmd.Parameters["@param3"].Value = appointments.Appointmenttime.ToString();
            cmd.Parameters.Add("@param4", MySqlDbType.VarChar);
            cmd.Parameters["@param4"].Value = appointments.PatientID.ToString();

            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.InsertCommand = cmd;
            adp.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Data Stored Successfully");


        }
    
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void Csharp_MySQL_Datagridview_Search_Load(object sender, EventArgs e)
        {
            searchData();
        }
        public void searchData()
        {
            string query = "SELECT * FROM APPOINTMENT";
            MySqlConnection connection = new MySqlConnection("DataSource=localhost;database=TestLabSystem ;uid=root;pwd=123456789");
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }


        private void Show_Click(object sender, EventArgs e)
        {
            string valueToSearch = textBox1.Text.ToString();
            searchData();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrar__Navigation_Screen f2 = new Registrar__Navigation_Screen();
            f2.Show();
        }

        private void PatientID_TextChanged(object sender, EventArgs e)
        {

        }
        

       
    }
}
