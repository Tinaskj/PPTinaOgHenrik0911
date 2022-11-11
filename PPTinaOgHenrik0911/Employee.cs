using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PPTinaOgHenrik0911
{
    internal class Employee
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public int EmployeePwd { get; private set; }
        private string Position { get; set; }

        public Employee(string name, int employeeId, int employeePwd, string position)
        {
            Name = name;
            EmployeeId = employeeId;
            EmployeePwd = employeePwd;
            Position = position;
        }
    }
}
