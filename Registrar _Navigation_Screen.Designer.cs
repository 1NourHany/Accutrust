namespace Test_Lab_System
{
    partial class Registrar__Navigation_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar__Navigation_Screen));
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ViewData = new System.Windows.Forms.Button();
            this.OrderTest = new System.Windows.Forms.Button();
            this.Appointment = new System.Windows.Forms.Button();
            this.NewPatient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(113, 16);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.ViewData);
            this.groupBox1.Controls.Add(this.OrderTest);
            this.groupBox1.Controls.Add(this.Appointment);
            this.groupBox1.Controls.Add(this.vScrollBar1);
            this.groupBox1.Controls.Add(this.NewPatient);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 416);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation Bar";
            // 
            // ViewData
            // 
            this.ViewData.BackColor = System.Drawing.Color.SteelBlue;
            this.ViewData.Location = new System.Drawing.Point(0, 335);
            this.ViewData.Name = "ViewData";
            this.ViewData.Size = new System.Drawing.Size(113, 57);
            this.ViewData.TabIndex = 10;
            this.ViewData.Text = "View Data";
            this.ViewData.UseVisualStyleBackColor = false;
            this.ViewData.Click += new System.EventHandler(this.ViewData_Click);
            // 
            // OrderTest
            // 
            this.OrderTest.BackColor = System.Drawing.Color.SteelBlue;
            this.OrderTest.Location = new System.Drawing.Point(0, 238);
            this.OrderTest.Name = "OrderTest";
            this.OrderTest.Size = new System.Drawing.Size(113, 57);
            this.OrderTest.TabIndex = 9;
            this.OrderTest.Text = "Order Test";
            this.OrderTest.UseVisualStyleBackColor = false;
            this.OrderTest.Click += new System.EventHandler(this.OrderTest_Click);
            // 
            // Appointment
            // 
            this.Appointment.BackColor = System.Drawing.Color.SteelBlue;
            this.Appointment.Location = new System.Drawing.Point(0, 131);
            this.Appointment.Name = "Appointment";
            this.Appointment.Size = new System.Drawing.Size(113, 62);
            this.Appointment.TabIndex = 8;
            this.Appointment.Text = "Appointment";
            this.Appointment.UseVisualStyleBackColor = false;
            this.Appointment.Click += new System.EventHandler(this.Appointment_Click);
            // 
            // NewPatient
            // 
            this.NewPatient.BackColor = System.Drawing.Color.SteelBlue;
            this.NewPatient.Location = new System.Drawing.Point(0, 42);
            this.NewPatient.Name = "NewPatient";
            this.NewPatient.Size = new System.Drawing.Size(113, 54);
            this.NewPatient.TabIndex = 3;
            this.NewPatient.Text = "Add Patient";
            this.NewPatient.UseVisualStyleBackColor = false;
            this.NewPatient.Click += new System.EventHandler(this.NewPatient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Registrar__Navigation_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registrar__Navigation_Screen";
            this.Text = "Registrar__Navigation_Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registrar__Navigation_Screen_FormClosed);
            this.Load += new System.EventHandler(this.Registrar__Navigation_Screen_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NewPatient;
        private System.Windows.Forms.Button OrderTest;
        private System.Windows.Forms.Button Appointment;
        private System.Windows.Forms.Button ViewData;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}