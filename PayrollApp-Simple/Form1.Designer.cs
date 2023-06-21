
namespace PayrollApp_Simple
{
    partial class Form1
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
            this.lst_display = new System.Windows.Forms.ListView();
            this.ch1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_export = new System.Windows.Forms.Button();
            this.grpbx_employee = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_jobsite = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_hours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_lastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_firstname = new System.Windows.Forms.TextBox();
            this.btn_addEmp = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.grpbx_employee.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_display
            // 
            this.lst_display.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch1,
            this.ch2,
            this.ch3,
            this.ch4,
            this.ch5});
            this.lst_display.FullRowSelect = true;
            this.lst_display.GridLines = true;
            this.lst_display.HideSelection = false;
            this.lst_display.Location = new System.Drawing.Point(413, 14);
            this.lst_display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lst_display.Name = "lst_display";
            this.lst_display.Size = new System.Drawing.Size(607, 398);
            this.lst_display.TabIndex = 0;
            this.lst_display.UseCompatibleStateImageBehavior = false;
            this.lst_display.View = System.Windows.Forms.View.Details;
            // 
            // ch1
            // 
            this.ch1.Text = "Employee ID:";
            this.ch1.Width = 100;
            // 
            // ch2
            // 
            this.ch2.Text = "First Name:";
            this.ch2.Width = 100;
            // 
            // ch3
            // 
            this.ch3.Text = "Last Name:";
            this.ch3.Width = 100;
            // 
            // ch4
            // 
            this.ch4.Text = "Hours Worked:";
            this.ch4.Width = 100;
            // 
            // ch5
            // 
            this.ch5.Text = "Jobsite:";
            this.ch5.Width = 150;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(663, 434);
            this.btn_export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(117, 49);
            this.btn_export.TabIndex = 1;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // grpbx_employee
            // 
            this.grpbx_employee.Controls.Add(this.label4);
            this.grpbx_employee.Controls.Add(this.combo_jobsite);
            this.grpbx_employee.Controls.Add(this.label3);
            this.grpbx_employee.Controls.Add(this.txtbx_hours);
            this.grpbx_employee.Controls.Add(this.label2);
            this.grpbx_employee.Controls.Add(this.txtbx_lastname);
            this.grpbx_employee.Controls.Add(this.label1);
            this.grpbx_employee.Controls.Add(this.txtbx_firstname);
            this.grpbx_employee.Location = new System.Drawing.Point(13, 14);
            this.grpbx_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbx_employee.Name = "grpbx_employee";
            this.grpbx_employee.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbx_employee.Size = new System.Drawing.Size(360, 398);
            this.grpbx_employee.TabIndex = 11;
            this.grpbx_employee.TabStop = false;
            this.grpbx_employee.Text = "Employee:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Select a Jobsite:";
            // 
            // combo_jobsite
            // 
            this.combo_jobsite.FormattingEnabled = true;
            this.combo_jobsite.Items.AddRange(new object[] {
            "(Select)",
            "Jobsite 1",
            "Jobsite 2",
            "Jobsite 3",
            "Jobsite 4",
            "Jobsite 5",
            "Jobsite 6",
            "Jobsite 7",
            "Jobsite 8",
            "Jobsite 9",
            "Jobsite 10",
            "Jobsite 11"});
            this.combo_jobsite.Location = new System.Drawing.Point(21, 300);
            this.combo_jobsite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_jobsite.Name = "combo_jobsite";
            this.combo_jobsite.Size = new System.Drawing.Size(145, 24);
            this.combo_jobsite.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hours Worked:";
            // 
            // txtbx_hours
            // 
            this.txtbx_hours.Location = new System.Drawing.Point(21, 212);
            this.txtbx_hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_hours.Name = "txtbx_hours";
            this.txtbx_hours.Size = new System.Drawing.Size(145, 22);
            this.txtbx_hours.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Last Name";
            // 
            // txtbx_lastname
            // 
            this.txtbx_lastname.Location = new System.Drawing.Point(21, 134);
            this.txtbx_lastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_lastname.Name = "txtbx_lastname";
            this.txtbx_lastname.Size = new System.Drawing.Size(145, 22);
            this.txtbx_lastname.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Name:";
            // 
            // txtbx_firstname
            // 
            this.txtbx_firstname.Location = new System.Drawing.Point(21, 57);
            this.txtbx_firstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_firstname.Name = "txtbx_firstname";
            this.txtbx_firstname.Size = new System.Drawing.Size(145, 22);
            this.txtbx_firstname.TabIndex = 11;
            // 
            // btn_addEmp
            // 
            this.btn_addEmp.Location = new System.Drawing.Point(69, 434);
            this.btn_addEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addEmp.Name = "btn_addEmp";
            this.btn_addEmp.Size = new System.Drawing.Size(109, 33);
            this.btn_addEmp.TabIndex = 19;
            this.btn_addEmp.Text = "Add to Payroll";
            this.btn_addEmp.UseVisualStyleBackColor = true;
            this.btn_addEmp.Click += new System.EventHandler(this.btn_addEmp_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(232, 434);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(109, 33);
            this.btn_reset.TabIndex = 20;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 528);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_addEmp);
            this.Controls.Add(this.grpbx_employee);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.lst_display);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Simple Payroll";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbx_employee.ResumeLayout(false);
            this.grpbx_employee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lst_display;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.GroupBox grpbx_employee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_jobsite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_hours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_firstname;
        private System.Windows.Forms.Button btn_addEmp;
        private System.Windows.Forms.ColumnHeader ch1;
        private System.Windows.Forms.ColumnHeader ch2;
        private System.Windows.Forms.ColumnHeader ch3;
        private System.Windows.Forms.ColumnHeader ch4;
        private System.Windows.Forms.ColumnHeader ch5;
        private System.Windows.Forms.Button btn_reset;
    }
}

