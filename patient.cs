using System;
using Test_Lab_System.Models;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace Test_Lab_System
{
    public partial class patient : System.Windows.Forms.Form
    {


        public patient()
        {
            InitializeComponent();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(160, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(160, 0, 0, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {

            //database insert patient
            MySqlConnection conn = new MySqlConnection("server=localhost;database=testlabsystem;uid=root;pwd=root");
            MySqlCommand cmd = null;
            //string cmdString = "";
            conn.Open();
            string cmdString = "insert into REGISTRATION(PatientID ,PatientFirstName , PatientLastName, PatientAge, PatientGender ,PatientMobilePhone," +
    "PatientNationalID, PatientAddress , PatientMaritalStatus, PatientBloodType, PatientNationality , PatientEmail, PatientDOB , PatientJob , " +
    "PatientMotherName , InsuranceCompany , InsuranceAddress, InsurancePhone, InsuranceSubscriberName, PatientHomePhone,EmergencyContactName," +
    " EmergencyContactMobile, EmergencyContactRelationship) values(@param1, @param2 , @param3  , @param4," +
    "@param5, @param6 , @param7  , @param8,@param9, @param10 , @param11  , @param12,@param13, @param14 ," +
    " @param15  , @param16, @param17 , @param18  , @param19,@param20, @param21 , @param22 , @param23 );";
            cmd = new MySqlCommand(cmdString, conn);
            //Add paramter values
            cmd.Parameters.AddWithValue("@param1", this.textBox1.Text);
            cmd.Parameters.AddWithValue("@param2", this.FirstName.Text);
            cmd.Parameters.AddWithValue("@param3", this.LastName.Text);
            cmd.Parameters.AddWithValue("@param4", this.Age.Text);
            cmd.Parameters.AddWithValue("@param5", this.Gender.Text);
            cmd.Parameters.AddWithValue("@param6", this.MobileNumber.Text);
            cmd.Parameters.AddWithValue("@param7", this.NationalID.Text);
            cmd.Parameters.AddWithValue("@param8", this.Address.Text);
            cmd.Parameters.AddWithValue("@param9", this.MaritalStatus.Text);
            cmd.Parameters.AddWithValue("@param10", this.BloodType.Text);
            cmd.Parameters.AddWithValue("@param11", this.Nationality.Text);
            cmd.Parameters.AddWithValue("@param12", this.Email.Text);
            cmd.Parameters.AddWithValue("@param13", this.DOB.Text);
            cmd.Parameters.AddWithValue("@param14", this.Job.Text);
            cmd.Parameters.AddWithValue("@param15", this.MotherName.Text);
            cmd.Parameters.AddWithValue("@param16", this.InsuranceCompany.Text);
            cmd.Parameters.AddWithValue("@param17", this.InsuranceAddress.Text);
            cmd.Parameters.AddWithValue("@param18", this.InsuranceNumber.Text);
            cmd.Parameters.AddWithValue("@param19", this.SubscriberName.Text);
            cmd.Parameters.AddWithValue("@param20", this.Home.Text);
            cmd.Parameters.AddWithValue("@param21", this.EmergencyName.Text);
            cmd.Parameters.AddWithValue("@param22", this.EmergencyPhone.Text);
            cmd.Parameters.AddWithValue("@param23", this.EmergencyRelationship.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Stored Successfully");
           
            }

        
        private void PatientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAppointment f2 = new AddAppointment();
            f2.Show();
        }
    }

}

