using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Lab_System.Models;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Configuration;
using System.ComponentModel.DataAnnotations;
namespace Test_Lab_System
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Employee Employee = new Employee();
            Employee.EmployeeID = EmployeeID.Text;
            Employee.EmployeeName = EmployeeName.Text;
            Employee.EmployeeAge = EmployeeAge.Text;
            Employee.EmployeeGender = gender.Text;
            Employee.EmployeePhone = EmployeePhone.Text;
            Employee.EmployeeNationalID = NationalID.Text;
            Employee.EmployeeMaritalStatus = MaritalStatus.Text;
            Employee.EmployeeNationality = Nationality.Text;
            Employee.EmployeeEmail = EmployeeEmail.Text;
            Employee.EmployeeDB = EmployeeDB.Text;
            Employee.EmployeePosition = EmployeePosition.Text;
            Employee.EmployeeDepartment = EmployeeDepartment.Text;
            Employee.EmployeePassword = EmployeePassword.Text;
            Employee.EmployeeSalary = Salary.Text;
            Employee.EmployeeSupervisor = EmployeeSupervisor.Text;
            
            ValidationContext validationContext = new ValidationContext(Employee);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(Employee, validationContext, errors, true))
            {
                foreach (var item in errors)
                {
                    switch (item.MemberNames.First())
                    {
                        case "EmployeeID":
                            Lbl_PatientIDError.Text = item.ErrorMessage;
                            Lbl_PatientIDError.ForeColor = Color.Red;
                            break;
                        case "FirstName":
                            Lbl_FNameError.Text = item.ErrorMessage;
                            Lbl_FNameError.ForeColor = Color.Red;
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
                        case "PatientNationality":
                            PatientEmail.Text = item.ErrorMessage;
                            PatientEmail.ForeColor = Color.Red;
                            break;
                        case "PatientEmail":
                            Supervisor.Text = item.ErrorMessage;
                            Supervisor.ForeColor = Color.Red;
                            break;
                        case "Salary":
                            Salary1.Text = item.ErrorMessage;
                            Salary1.ForeColor = Color.Red;
                            break;

                        case "Position":
                            Position.Text = item.ErrorMessage;
                            Position.ForeColor = Color.Red;
                            break;
                        case "PatientSuperVisor":
                            Supervisor.Text = item.ErrorMessage;
                            Supervisor.ForeColor = Color.Red;
                            break;
                        case "Department":
                            Department.Text = item.ErrorMessage;
                            Department.ForeColor = Color.Red;
                            break;
                        case "Password":
                            Password.Text = item.ErrorMessage;
                            Password.ForeColor = Color.Red;
                            break;


                        default:
                            MessageBox.Show(item.ErrorMessage);
                            break;
                    }
                }
            }
            else
            {
                try
                {

                    MySqlConnection conn = new MySqlConnection("server=localhost;database=dentistryclinic;uid=root;pwd=123456789");
                    MySqlCommand comd = null;

                    conn.Open();

                    string comdString = "Insert into EMPLOYEE (EmployeeID, EmployeeName, EmployeeAge," +
                            " EmployeeSalary, EmployeePhone, EmployeeEmail,EmployeeDB, EmployeePosition, " +
                            "EmployeePassword , EmployeeDepartment, EmployeeSupervisor,EmployeeMaritalStatus, " +
                            "Employeegender , EmployeeNationality,  EmployeeNationalID) VALUES(@param1, @param2 , " +
                            "@param22 ,@param3, @param4 , @param5,@param6 , @param7  , @param8 , @param9, " +
                            "@param10 , @param11  , @param12 , @param13 , @param14 );";
                    comd = new MySqlCommand(comdString, conn);

                    comd.Parameters.Add("@param1", MySqlDbType.VarChar);
                    comd.Parameters["@param1"].Value = Employee.EmployeeID.ToString();
                    comd.Parameters.Add("@param2", MySqlDbType.VarChar);
                    comd.Parameters["@param2"].Value = Employee.EmployeeName.ToString();
                    comd.Parameters.Add("@param22", MySqlDbType.VarChar);
                    comd.Parameters["@param22"].Value = Employee.EmployeeAge.ToString();
                    comd.Parameters.Add("@param3", MySqlDbType.VarChar);
                    comd.Parameters["@param3"].Value = Employee.EmployeeSalary.ToString();
                    comd.Parameters.Add("@param4", MySqlDbType.VarChar);
                    comd.Parameters["@param4"].Value = Employee.EmployeePhone.ToString();
                    comd.Parameters.Add("@param5", MySqlDbType.VarChar);
                    comd.Parameters["@param5"].Value = Employee.EmployeeEmail.ToString();
                    comd.Parameters.Add("@param6", MySqlDbType.VarChar);
                    comd.Parameters["@param6"].Value = Employee.EmployeeDB.ToString();
                    comd.Parameters.Add("@param7", MySqlDbType.VarChar);
                    comd.Parameters["@param7"].Value = Employee.EmployeePosition.ToString();
                    comd.Parameters.Add("@param8", MySqlDbType.VarChar);
                    comd.Parameters["@param8"].Value = Employee.EmployeePassword.ToString();
                    comd.Parameters.Add("@param9", MySqlDbType.VarChar);
                    comd.Parameters["@param9"].Value = Employee.EmployeeDepartment.ToString();
                    comd.Parameters.Add("@param10", MySqlDbType.VarChar);
                    comd.Parameters["@param10"].Value = Employee.EmployeeSupervisor.ToString();
                    comd.Parameters.Add("@param11", MySqlDbType.VarChar);
                    comd.Parameters["@param11"].Value = Employee.EmployeeMaritalStatus.ToString();
                    comd.Parameters.Add("@param12", MySqlDbType.VarChar);
                    comd.Parameters["@param12"].Value = Employee.EmployeeGender.ToString();
                    comd.Parameters.Add("@param13", MySqlDbType.VarChar);
                    comd.Parameters["@param13"].Value = Employee.EmployeeNationality.ToString();
                    comd.Parameters.Add("@param14", MySqlDbType.VarChar);
                    comd.Parameters["@param14"].Value = Employee.EmployeeNationalID.ToString();
                    MySqlDataAdapter adp = new MySqlDataAdapter();
                    adp.InsertCommand = comd;
                    adp.InsertCommand.ExecuteNonQuery();
                   
                    MessageBox.Show("Data Stored Successfully");
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }


        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminView f2 = new AdminView();
            f2.Show();
        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void EmployeeSupervisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void supervisor_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            EmployeeSupervisor.MaxLength = 25;
            
            
        }

        private void EmployeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
            EmployeeName.MaxLength = 25;
        }

        private void EmployeeID_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void EmployeeSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            Salary.MaxLength = 4;
        }

        private void EmployeeAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            
        }
            EmployeeAge.MaxLength = 2;
        }

        private void EmployeePhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            EmployeePhone.MaxLength = 11;
        }

        private void NationalID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            NationalID.MaxLength = 14;
        }

        private void EmployeePassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            EmployeePassword.MaxLength = 8;
        }

        private void gender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                //e.Handled = true;
                MessageBox.Show("Please enter only letters.");
                gender.Text = gender.Text.Remove(gender.Text.Length - 1);
            }
            gender.MaxLength = 6;
        }

        private void EmployeeEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            EmployeeEmail.MaxLength = 30;
        }

        private void MaritalStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaritalStatus.MaxLength = 10;

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Nationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            Nationality.MaxLength = 20;
        }

        private void EmployeePosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only letters.");
                EmployeePosition.Clear();
                EmployeePosition.Focus();

            }
            EmployeePosition.MaxLength = 25;
        }

        private void EmployeeDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only letters.");
                EmployeeDepartment.Clear();
                EmployeeDepartment.Focus();



            }
            EmployeeDepartment.MaxLength = 25;
        }

        private void EmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            EmployeeID.MaxLength = 8;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
