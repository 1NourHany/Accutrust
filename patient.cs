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
using System.Text.RegularExpressions;
using System.Configuration;
using System.ComponentModel.DataAnnotations;

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
            //panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            //panel2.BackColor = Color.FromArgb(160, 0, 0, 0);
            //panel3.BackColor = Color.FromArgb(160, 0, 0, 0);

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
            //dfjdfbjdbfdj


            REGISTRATION Registration = new REGISTRATION();
            Registration.PatientID = textBox1.Text;
            Registration.PatientFirstName = FirstName.Text;
            Registration.PatientLastName = LastName.Text;
            Registration.PatientAge = PatientAge.Text;
            Registration.PatientGender = PatientGender.Text;
            Registration.PatientMobilePhone = MobileNumber.Text;
            Registration.PatientNationalID = NationalID.Text;
            Registration.PatientAddress = Address.Text;
            Registration.PatientMaritalStatus = MaritalStatus.Text;
            Registration.PatientBloodType = BloodType.Text;
            Registration.PatientNationality = Nationality.Text;
            Registration.PatientEmail = Email.Text;
            Registration.PatientDOB = DOB.Text;
            Registration.PatientJob = Job.Text;
            Registration.PatientMotherName = MotherName.Text;
            Registration.InsuranceCompany = InsuranceCompany.Text;
            Registration.InsuranceAddress = InsuranceAddress.Text;
            Registration.InsurancePhone = InsuranceNumber.Text;
            Registration.InsuranceSubscriberName = SubscriberName.Text;
            Registration.PatientHomePhone = Home.Text;
            Registration.EmergencyContactName = EmergencyName.Text;
            Registration.EmergencyContactMobile = EmergencyPhone.Text;
            Registration.EmergencyContactRelationship = EmergencyRelationship.Text;
            Registration.PatientAddress = Address.Text;
            MySqlConnection conn = new MySqlConnection("server=localhost;database=testlabsystem;uid=root;pwd=123456789");
            MySqlCommand cmd = null;
            //string cmdString = "";
            conn.Open();
            //using (MySqlConnection conn = new MySqlConnection("server=localhost;database=testlabsystem;uid=root;pwd=123456789"))
            //{
            //  conn.Open();
            // try
            //{

            string cmdString = "insert into REGISTRATION(PatientID ,PatientFirstName , PatientLastName, PatientAge, PatientGender ,PatientMobilePhone," +
    "PatientNationalID, PatientAddress , PatientMaritalStatus, PatientBloodType, PatientNationality , PatientEmail, PatientDOB , PatientJob , " +
    "PatientMotherName , InsuranceCompany , InsuranceAddress, InsurancePhone, InsuranceSubscriberName, PatientHomePhone,EmergencyContactName," +
    " EmergencyContactMobile, EmergencyContactRelationship) values(@param1, @param2 , @param3  , @param4," +
    "@param44, @param5,@param6 , @param7  , @param8,@param9, @param10 , @param11  , @param12,@param13, @param14 ," +
    " @param15  , @param16, @param17 , @param18  , @param19,@param20, @param21 , @param22 );";
            //cmd = new MySqlCommand(cmdString, conn);
            //Add paramter values
            // cmd = new MySqlCommand(cmdString, conn);
            cmd = new MySqlCommand(cmdString, conn);

            cmd.Parameters.Add("@param1", MySqlDbType.VarChar);
            cmd.Parameters["@param1"].Value = Registration.PatientID.ToString();
            cmd.Parameters.Add("@param2", MySqlDbType.VarChar);
            cmd.Parameters["@param2"].Value = Registration.PatientFirstName.ToString();
            cmd.Parameters.Add("@param3", MySqlDbType.VarChar);
            cmd.Parameters["@param3"].Value = Registration.PatientLastName.ToString();
            cmd.Parameters.Add("@param4", MySqlDbType.VarChar);
            cmd.Parameters["@param4"].Value = Registration.PatientAge.ToString();
            cmd.Parameters.Add("@param44", MySqlDbType.VarChar);
            cmd.Parameters["@param44"].Value = Registration.PatientGender.ToString();
            cmd.Parameters.Add("@param5", MySqlDbType.VarChar);
            cmd.Parameters["@param5"].Value = Registration.PatientMobilePhone.ToString();
            cmd.Parameters.Add("@param6", MySqlDbType.VarChar);
            cmd.Parameters["@param6"].Value = Registration.PatientNationalID.ToString();
            cmd.Parameters.Add("@param7", MySqlDbType.VarChar);
            cmd.Parameters["@param7"].Value = Registration.PatientAddress.ToString();
            cmd.Parameters.Add("@param8", MySqlDbType.VarChar);
            cmd.Parameters["@param8"].Value = Registration.PatientMaritalStatus.ToString();
            cmd.Parameters.Add("@param9", MySqlDbType.VarChar);
            cmd.Parameters["@param9"].Value = Registration.PatientBloodType.ToString();
            cmd.Parameters.Add("@param10", MySqlDbType.VarChar);
            cmd.Parameters["@param10"].Value = Registration.PatientNationality.ToString();
            cmd.Parameters.Add("@param11", MySqlDbType.VarChar);
            cmd.Parameters["@param11"].Value = Registration.PatientEmail.ToString();
            cmd.Parameters.Add("@param12", MySqlDbType.VarChar);
            cmd.Parameters["@param12"].Value = Registration.PatientDOB.ToString();
            cmd.Parameters.Add("@param13", MySqlDbType.VarChar);
            cmd.Parameters["@param13"].Value = Registration.PatientJob.ToString();
            cmd.Parameters.Add("@param14", MySqlDbType.VarChar);
            cmd.Parameters["@param14"].Value = Registration.PatientMotherName.ToString();
            cmd.Parameters.Add("@param15", MySqlDbType.VarChar);
            cmd.Parameters["@param15"].Value = Registration.InsuranceCompany.ToString();
            cmd.Parameters.Add("@param16", MySqlDbType.VarChar);
            cmd.Parameters["@param16"].Value = Registration.InsuranceAddress.ToString();
            cmd.Parameters.Add("@param17", MySqlDbType.VarChar);
            cmd.Parameters["@param17"].Value = Registration.InsurancePhone.ToString();
            cmd.Parameters.Add("@param18", MySqlDbType.VarChar);
            cmd.Parameters["@param18"].Value = Registration.InsuranceSubscriberName.ToString();
            cmd.Parameters.Add("@param19", MySqlDbType.VarChar);
            cmd.Parameters["@param19"].Value = Registration.PatientHomePhone.ToString();
            cmd.Parameters.Add("@param20", MySqlDbType.VarChar);
            cmd.Parameters["@param20"].Value = Registration.EmergencyContactName.ToString();
            cmd.Parameters.Add("@param21", MySqlDbType.VarChar);
            cmd.Parameters["@param21"].Value = Registration.EmergencyContactMobile.ToString();
            cmd.Parameters.Add("@param22", MySqlDbType.VarChar);
            cmd.Parameters["@param22"].Value = Registration.EmergencyContactRelationship.ToString(); ;
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.InsertCommand = cmd;
            adp.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Data Stored Successfully");
          
            AddAppointment obj = new AddAppointment(textBox1.Text);
            obj.Show();


        }





        private void PatientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //AddAppointment f2 = new AddAppointment();
            //f2.Show();
        }

        private void Click_Menu(object sender, EventArgs e)
        {
            this.Hide();
            Registrar__Navigation_Screen f2 = new Registrar__Navigation_Screen();
            f2.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Fname_keypress(object sender, KeyPressEventArgs e)
        {
            FirstName.MaxLength = 10;
        }

        private void mobile_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            MobileNumber.MaxLength = 11;
        }

        private void Lname_keypress(object sender, KeyPressEventArgs e)
        {
            LastName.MaxLength = 10;
        }

        private void Address_keypress(object sender, KeyPressEventArgs e)
        {
            LastName.MaxLength = 40;
        }

        private void Age_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            PatientAge.MaxLength = 2;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void MobileNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }



}