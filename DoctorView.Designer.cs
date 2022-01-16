namespace Test_Lab_System
{
    partial class DoctorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorView));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AppDate = new System.Windows.Forms.DateTimePicker();
            this.ReportDate = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.PatientAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PhysicianName = new System.Windows.Forms.TextBox();
            this.PatientID = new System.Windows.Forms.TextBox();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.CBCTest = new System.Windows.Forms.CheckBox();
            this.Endocrinology = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(321, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Patient Test ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.AppDate);
            this.groupBox1.Controls.Add(this.ReportDate);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.PatientAge);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PhysicianName);
            this.groupBox1.Controls.Add(this.PatientID);
            this.groupBox1.Controls.Add(this.PatientName);
            this.groupBox1.Location = new System.Drawing.Point(23, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(741, 118);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AppDate
            // 
            this.AppDate.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppDate.CalendarForeColor = System.Drawing.Color.Purple;
            this.AppDate.CalendarMonthBackground = System.Drawing.Color.Red;
            this.AppDate.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.AppDate.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.AppDate.CalendarTrailingForeColor = System.Drawing.Color.Red;
            this.AppDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AppDate.Location = new System.Drawing.Point(374, 82);
            this.AppDate.Margin = new System.Windows.Forms.Padding(5);
            this.AppDate.Name = "AppDate";
            this.AppDate.Size = new System.Drawing.Size(102, 21);
            this.AppDate.TabIndex = 31;
            this.AppDate.Value = new System.DateTime(2021, 12, 9, 0, 0, 0, 0);
            // 
            // ReportDate
            // 
            this.ReportDate.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportDate.CalendarForeColor = System.Drawing.Color.Purple;
            this.ReportDate.CalendarMonthBackground = System.Drawing.Color.Red;
            this.ReportDate.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.ReportDate.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.ReportDate.CalendarTrailingForeColor = System.Drawing.Color.Red;
            this.ReportDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReportDate.Location = new System.Drawing.Point(13, 88);
            this.ReportDate.Margin = new System.Windows.Forms.Padding(5);
            this.ReportDate.Name = "ReportDate";
            this.ReportDate.Size = new System.Drawing.Size(102, 21);
            this.ReportDate.TabIndex = 30;
            this.ReportDate.Value = new System.DateTime(2022, 1, 11, 0, 0, 0, 0);
            this.ReportDate.ValueChanged += new System.EventHandler(this.ReportDate_ValueChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(493, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 19);
            this.button5.TabIndex = 28;
            this.button5.Text = "Check";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // PatientAge
            // 
            this.PatientAge.Location = new System.Drawing.Point(374, 26);
            this.PatientAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatientAge.Name = "PatientAge";
            this.PatientAge.Size = new System.Drawing.Size(86, 20);
            this.PatientAge.TabIndex = 26;
            this.PatientAge.Text = "Patient Age";
            this.PatientAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientAge_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Report Date";
            // 
            // PhysicianName
            // 
            this.PhysicianName.Location = new System.Drawing.Point(211, 85);
            this.PhysicianName.Name = "PhysicianName";
            this.PhysicianName.Size = new System.Drawing.Size(100, 20);
            this.PhysicianName.TabIndex = 15;
            this.PhysicianName.Text = "Physician Name";
            this.PhysicianName.TextChanged += new System.EventHandler(this.PhysicianName_TextChanged);
            this.PhysicianName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhysicianName_KeyPress);
            // 
            // PatientID
            // 
            this.PatientID.Location = new System.Drawing.Point(211, 26);
            this.PatientID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatientID.Name = "PatientID";
            this.PatientID.Size = new System.Drawing.Size(86, 20);
            this.PatientID.TabIndex = 6;
            this.PatientID.Text = "Patient ID";
            this.PatientID.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.PatientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientID_KeyPress);
            // 
            // PatientName
            // 
            this.PatientName.Location = new System.Drawing.Point(13, 26);
            this.PatientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(86, 20);
            this.PatientName.TabIndex = 6;
            this.PatientName.Text = "Patient Name";
            this.PatientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientName_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(855, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(132, 66);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 19);
            this.button2.TabIndex = 19;
            this.button2.Text = "CBC Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Another Patient Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 22);
            this.button4.TabIndex = 22;
            this.button4.Text = "Endocrinology Test";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(855, 260);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(163, 61);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 31;
            // 
            // CBCTest
            // 
            this.CBCTest.AutoSize = true;
            this.CBCTest.BackColor = System.Drawing.Color.Transparent;
            this.CBCTest.Location = new System.Drawing.Point(22, 43);
            this.CBCTest.Name = "CBCTest";
            this.CBCTest.Size = new System.Drawing.Size(71, 17);
            this.CBCTest.TabIndex = 32;
            this.CBCTest.Text = "CBC Test";
            this.CBCTest.UseVisualStyleBackColor = false;
            this.CBCTest.CheckedChanged += new System.EventHandler(this.CBCTest_CheckedChanged);
            // 
            // Endocrinology
            // 
            this.Endocrinology.AutoSize = true;
            this.Endocrinology.BackColor = System.Drawing.Color.Transparent;
            this.Endocrinology.Location = new System.Drawing.Point(20, 77);
            this.Endocrinology.Name = "Endocrinology";
            this.Endocrinology.Size = new System.Drawing.Size(93, 17);
            this.Endocrinology.TabIndex = 33;
            this.Endocrinology.Text = "Endocrinology";
            this.Endocrinology.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(613, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 13);
            this.textBox1.TabIndex = 32;
            this.textBox1.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.ForeColor = System.Drawing.Color.LightCyan;
            this.label5.Location = new System.Drawing.Point(349, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "                         ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.CBCTest);
            this.groupBox2.Controls.Add(this.Endocrinology);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(25, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 100);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tests Information";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(436, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 85);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insert Results in";
            // 
            // DoctorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 523);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "DoctorView";
            this.Text = "DoctorView";
            this.Load += new System.EventHandler(this.DoctorView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.TextBox PhysicianName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PatientAge;
        private System.Windows.Forms.TextBox PatientID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker AppDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CBCTest;
        private System.Windows.Forms.CheckBox Endocrinology;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker ReportDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}