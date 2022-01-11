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
            //database insert patient
            //dfjdfbjdbfdj


            Employee employee = new Employee();
            employee.EmployeeID = EmployeeID.Text;
            employee.EmployeeName = EmployeeName.Text;
            employee.EmployeeAge = EmployeeAge.Text;
            employee.EmployeeGender = gender.Text;
            employee.EmployeePhone = EmployeePhone.Text;
            employee.EmployeeNationalID = NationalID.Text;
            employee.EmployeeMaritalStatus = MaritalStatus.Text;
            employee.EmployeeNationality = Nationality.Text;
            employee.EmployeeEmail = EmployeeEmail.Text;
            employee.EmployeeDB = EmployeeDB.Text;
            employee.EmployeePosition = EmployeePosition.Text;
            employee.EmployeeDepartment = EmployeeDepartment.Text;
            employee.EmployeePassword = EmployeePassword.Text;
            employee.EmployeeSalary = EmployeeSalary.Text;
            employee.EmployeeSupervisor = EmployeeSupervisor.Text;
            MySqlConnection connn = new MySqlConnection("server=localhost;database=testlabsystem;uid=root;pwd=123456789");
            MySqlCommand comd = null;
            //string cmdString = "";
            connn.Open();
            //using (MySqlConnection conn = new MySqlConnection("server=localhost;database=testlabsystem;uid=root;pwd=123456789"))
            //{
            //  conn.Open();
            // try
            //{

            string comdString = "Insert into EMPLOYEE (EmployeeID, EmployeeName, EmployeeAge," +
                " EmployeeSalary, EmployeePhone, EmployeeEmail,EmployeeDB, EmployeePosition, " +
                "EmployeePassword , EmployeeDepartment, EmployeeSupervisor,EmployeeMaritalStatus, " +
                "Employeegender , EmployeeNationality,  EmployeeNationalID) VALUES(@param1, @param2 , " +
                "@param22 ,@param3, @param4 , @param5,@param6 , @param7  , @param8 , @param9, " +
                "@param10 , @param11  , @param12 , @param13 , @param14 );";
            //cmd = new MySqlCommand(cmdString, conn);
            //Add paramter values
            // cmd = new MySqlCommand(cmdString, conn);
            comd = new MySqlCommand(comdString, connn);

            comd.Parameters.Add("@param1", MySqlDbType.VarChar);
            comd.Parameters["@param1"].Value = employee.EmployeeID.ToString();
            comd.Parameters.Add("@param2", MySqlDbType.VarChar);
            comd.Parameters["@param2"].Value = employee.EmployeeName.ToString();
            comd.Parameters.Add("@param22", MySqlDbType.VarChar);
            comd.Parameters["@param22"].Value = employee.EmployeeAge.ToString();
            comd.Parameters.Add("@param3", MySqlDbType.VarChar);
            comd.Parameters["@param3"].Value = employee.EmployeeSalary.ToString();
            comd.Parameters.Add("@param4", MySqlDbType.VarChar);
            comd.Parameters["@param4"].Value = employee.EmployeePhone.ToString();
            comd.Parameters.Add("@param5", MySqlDbType.VarChar);
            comd.Parameters["@param5"].Value = employee.EmployeeEmail.ToString();
            comd.Parameters.Add("@param6", MySqlDbType.VarChar);
            comd.Parameters["@param6"].Value = employee.EmployeeDB.ToString();
            comd.Parameters.Add("@param7", MySqlDbType.VarChar);
            comd.Parameters["@param7"].Value = employee.EmployeePosition.ToString();
            comd.Parameters.Add("@param8", MySqlDbType.VarChar);
            comd.Parameters["@param8"].Value = employee.EmployeePassword.ToString();
            comd.Parameters.Add("@param9", MySqlDbType.VarChar);
            comd.Parameters["@param9"].Value = employee.EmployeeDepartment.ToString();
            comd.Parameters.Add("@param10", MySqlDbType.VarChar);
            comd.Parameters["@param10"].Value = employee.EmployeeSupervisor.ToString();
            comd.Parameters.Add("@param11", MySqlDbType.VarChar);
            comd.Parameters["@param11"].Value = employee.EmployeeMaritalStatus.ToString();
            comd.Parameters.Add("@param12", MySqlDbType.VarChar);
            comd.Parameters["@param12"].Value = employee.EmployeeGender.ToString();
            comd.Parameters.Add("@param13", MySqlDbType.VarChar);
            comd.Parameters["@param13"].Value = employee.EmployeeNationality.ToString();
            comd.Parameters.Add("@param14", MySqlDbType.VarChar);
            comd.Parameters["@param14"].Value = employee.EmployeeNationalID.ToString();


            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.InsertCommand = comd;
            adp.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Data Stored Successfully");
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

        private void EmployeeID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(EmployeeID.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                EmployeeID.Text = EmployeeID.Text.Remove(EmployeeID.Text.Length - 1);
            }
        }

        private void EmployeeSupervisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void supervisor_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;               
                MessageBox.Show("Please enter only letters.");

            }
            
            
        }
    }
    
}
