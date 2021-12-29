using System;
using Test_Lab_System.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;
namespace Test_Lab_System
{
    public partial class AddAppointment : System.Windows.Forms.Form
    {
        public AddAppointment()
        {
            InitializeComponent();
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

    }
}
