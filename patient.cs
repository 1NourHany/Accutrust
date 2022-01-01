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
        public static string textpassedForm2;


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
            Registration.PatientAge = Age.Text;
            Registration.PatientGender = gender.Text;
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
            //Patient Validation
            ValidationContext validationContext = new ValidationContext(Registration);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(Registration, validationContext, errors, true))
            {
                foreach (var item in errors)
                {
                    switch (item.MemberNames.First())
                    {
                        case "PatientID":
                            Lbl_PatientIDError.Text = item.ErrorMessage;
                            Lbl_PatientIDError.ForeColor = Color.Red;
                            break;
                        case "PatientFirstName":
                            Lbl_FNameError.Text = item.ErrorMessage;
                            Lbl_FNameError.ForeColor = Color.Red;
                            break;
                        case "PatientLastName":
                            Lbl_LNameError.Text = item.ErrorMessage;
                            Lbl_LNameError.ForeColor = Color.Red;
                            break;
                        case "PatientAge":
                            Lbl_AgeError.Text = item.ErrorMessage;
                            Lbl_AgeError.ForeColor = Color.Red;
                            break;
                        case "PatientGender":
                            Lbl_GenderError.Text = item.ErrorMessage;
                            Lbl_GenderError.ForeColor = Color.Red;
                            break;
                        case "PatientMobilePhone":
                            Lbl_MobileNumberError.Text = item.ErrorMessage;
                            Lbl_MobileNumberError.ForeColor = Color.Red;
                            break;
                        case "PatientNationalID":
                            Lbl_NationalIDError.Text = item.ErrorMessage;
                            Lbl_NationalIDError.ForeColor = Color.Red;
                            break;
                        case "PatientMaritalStatus":
                            Lbl_MaritalStatusError.Text = item.ErrorMessage;
                            Lbl_MaritalStatusError.ForeColor = Color.Red;
                            break;
                        case "PatientBloodType":
                            Lbl_BloodTypeError.Text = item.ErrorMessage;
                            Lbl_BloodTypeError.ForeColor = Color.Red;
                            break;
                        case "PatientNationality":
                            LblNationality_Error.Text = item.ErrorMessage;
                            LblNationality_Error.ForeColor = Color.Red;
                            break;
                        case "PatientEmail":
                            Lbl_EmailError.Text = item.ErrorMessage;
                            Lbl_EmailError.ForeColor = Color.Red;
                            break;
                        case "PatientJob":
                            Lbl_JobError.Text = item.ErrorMessage;
                            Lbl_JobError.ForeColor = Color.Red;
                            break;
                        case "PatientMotherName":
                            Lbl_MotherNameError.Text = item.ErrorMessage;
                            Lbl_MotherNameError.ForeColor = Color.Red;
                            break;
                        case "InsuranceCompany":
                            Lbl_InsuranceCompanyError.Text = item.ErrorMessage;
                            Lbl_InsuranceCompanyError.ForeColor = Color.Red;
                            break;
                        case "InsuranceAddress":
                            Lbl_InsuranceAddressError.Text = item.ErrorMessage;
                            Lbl_InsuranceAddressError.ForeColor = Color.Red;
                            break;
                        case "InsurancePhone":
                            Lbl_InsurancePhoneError.Text = item.ErrorMessage;
                            Lbl_InsurancePhoneError.ForeColor = Color.Red;
                            break;
                        case "InsuranceSubscriberName":
                            Lbl_SubscriberNameError.Text = item.ErrorMessage;
                            Lbl_SubscriberNameError.ForeColor = Color.Red;
                            break;
                        case "PatientHomePhone":
                            Lbl_HomeError.Text = item.ErrorMessage;
                            Lbl_HomeError.ForeColor = Color.Red;
                            break;
                        case "EmergencyContactName":
                            Lbl_EmergencyNameError.Text = item.ErrorMessage;
                            Lbl_EmergencyNameError.ForeColor = Color.Red;
                            break;
                        case "EmergencyContactMobile":
                            Lbl_EmergencyPhoneError.Text = item.ErrorMessage;
                            Lbl_EmergencyPhoneError.ForeColor = Color.Red;
                            break;
                        case "EmergencyContactRelationship":
                            Lbl_EmergencyRelationshipError.Text = item.ErrorMessage;
                            Lbl_EmergencyRelationshipError.ForeColor = Color.Red;
                            break;
                        case "PatientAddress":
                            Lbl_AddressError.Text = item.ErrorMessage;
                            Lbl_AddressError.ForeColor = Color.Red;
                            break;
                        default:
                            MessageBox.Show(item.ErrorMessage);
                            break;
                    }
                }
            }
            else
            {
                //string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
                //MySqlCommand cmd = null;
                //string cmdString = "";
                //conn.Open();
                using (MySqlConnection conn = new MySqlConnection("server=localhost;database=testlabsystem;uid=root;pwd=123456789"))
                {
                    conn.Open();
                    try
                    {

                        MySqlCommand cmd = new MySqlCommand("insert into REGISTRATION(PatientID ,PatientFirstName , PatientLastName, PatientAge, PatientGender ,PatientMobilePhone," +
        "PatientNationalID, PatientAddress , PatientMaritalStatus, PatientBloodType, PatientNationality , PatientEmail, PatientDOB , PatientJob , " +
        "PatientMotherName , InsuranceCompany , InsuranceAddress, InsurancePhone, InsuranceSubscriberName, PatientHomePhone,EmergencyContactName," +
        " EmergencyContactMobile, EmergencyContactRelationship) values(@param1, @param2 , @param3  , @param4," +
        "@param44, @param5,@param6 , @param7  , @param8,@param9, @param10 , @param11  , @param12,@param13, @param14 ," +
        " @param15  , @param16, @param17 , @param18  , @param19,@param20, @param21 , @param22 );");
                        //cmd = new MySqlCommand(cmdString, conn);
                        //Add paramter values
                        // cmd = new MySqlCommand(cmdString, conn);
                        cmd.Parameters.Add("@param1", MySqlDbType.VarChar);
                        cmd.Parameters["@param1"].Value = Registration.PatientID.ToString();
                        cmd.Parameters.Add("@param2", MySqlDbType.VarChar);
                        cmd.Parameters["@param2"].Value = Registration.PatientFirstName.ToString();
                        cmd.Parameters.Add("@param3", MySqlDbType.VarChar);
                        cmd.Parameters["@param3"].Value = Registration.PatientLastName.ToString();
                        cmd.Parameters.Add("@param4", MySqlDbType.VarChar);
                        cmd.Parameters["@param4"].Value = Registration.PatientGender.ToString();
                        cmd.Parameters.Add("@param44", MySqlDbType.VarChar);
                        cmd.Parameters["@param44"].Value = Registration.PatientAge.ToString();
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
                        textpassedForm2 = textBox1.Text;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
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
            Age.MaxLength = 2; 
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
