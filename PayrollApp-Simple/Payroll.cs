using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp_Simple
{
    public class Payroll
    {
        private List<Employee> employeeList;

        public List<Employee> EmployeeList
        {
            get { return employeeList; }
            set { employeeList = value; }
        }

        public Payroll()
        {
            EmployeeList = new List<Employee>();
        }

        public int calc_hours()
        {
            int totalHrs = 0;
            foreach (var i in EmployeeList)
            {
                totalHrs += totalHrs + i.Hours;
            }
            return totalHrs;
        }

    }
}
