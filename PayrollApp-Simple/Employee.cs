using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp_Simple
{
    public class Employee
    {
        private string empid;

        public string Empid
        {
            get { return empid; }
            set { empid = value; }
        }

        private string empFirstName;

        public string EmpFirstName
        {
            get { return empFirstName; }
            set { empFirstName = value; }
        }

        private string empLastName;

        public string EmpLastName
        {
            get { return empLastName; }
            set { empLastName = value; }
        }

        private int hours;

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        private string jobSite;

        public string JobSite
        {
            get { return jobSite; }
            set { jobSite = value; }
        }

        public Employee()
        {
            this.EmpFirstName = "None";
            this.EmpLastName = "None";
            this.Hours = 0;
            this.JobSite = "None";
        }

        public Employee(string eID, string eFirstName , string eLastName, int hoursWorked, string eJobsite)
        { // e = employee

            empid = eID;
            empFirstName = eFirstName;
            empLastName = eLastName;
            hours = hoursWorked;
            jobSite = eJobsite;

        }

        public override string ToString()
        {
            return "ID: "+ empid + " Name: " + empFirstName + " " + empLastName + " Hours Worked: " + hours + " Jobsite: " + jobSite;
        }
    }
}
