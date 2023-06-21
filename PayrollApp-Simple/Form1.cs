using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollApp_Simple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Payroll payroll = new Payroll();
        BindingSource employeeBindingSource = new BindingSource();

        private static Random rnd = new Random();
        public static string RandomString(int length)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[rnd.Next(s.Length)]).ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combo_jobsite.SelectedIndex = 0;

        }
 
        private void btn_addEmp_Click(object sender, EventArgs e)
        {

            try
            {
                if (combo_jobsite.SelectedIndex != 0 )
                {
                    Employee employee = new Employee(
                        
                        RandomString(8),
                        txtbx_firstname.Text,
                        txtbx_lastname.Text,
                        int.Parse(txtbx_hours.Text),
                        combo_jobsite.Text);

                    string[] row = { 
                        employee.Empid, 
                        employee.EmpFirstName, 
                        employee.EmpLastName, 
                        employee.Hours.ToString(), 
                        employee.JobSite 
                    };

                    ListViewItem lvi = new ListViewItem(row);
                    lst_display.Items.Add(lvi);

                    txtbx_firstname.Clear();
                    txtbx_lastname.Clear();
                    txtbx_hours.Clear();
                    combo_jobsite.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("You Must Select a Jobsite...");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input: " +
                    "\n" + 
                    "\nEnsure each field has on of the following... " +
                    "\n\tFirst Name: Text " +
                    "\n\tLastName: Text " +
                    "\n\tHours Worked: Numerical Value " +
                    "\n\tSelected Jobsite: Use the dropdown") ;
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtbx_firstname.Clear();
            txtbx_lastname.Clear();
            txtbx_hours.Clear();
            combo_jobsite.SelectedIndex = 0;
            lst_display.Items.Clear();
        }

        private async void btn_export_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "CSV|*.csv",
                    ValidateNames = true
                })
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine(string.Format("{0},{1},{2},{3},{4}", lst_display.Columns[0].Text, lst_display.Columns[1].Text, lst_display.Columns[2].Text, lst_display.Columns[3].Text, lst_display.Columns[4].Text));
                            foreach (ListViewItem item in lst_display.Items)
                            {
                                sb.AppendLine(string.Format("{0},{1},{2},{3},{4}", item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text));
                            }
                            await sw.WriteLineAsync(sb.ToString());
                            MessageBox.Show("Data Saved.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
