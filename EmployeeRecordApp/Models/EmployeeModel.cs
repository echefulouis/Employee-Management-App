using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRecordApp.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpSSN { get; set; }
        public string EmpName { get; set; }
        public string EmpPhone { get; set; }
        public string EmpAddress { get; set; }
        public string EmpGender { get; set; }

        public string EmpPosition { get; set; }

        public EmployeeModel(int empId, string empSSN, string empName, string empAddress, string empPhone, string empGender, string empPosition)
        {
            EmpId = empId;
            EmpSSN = empSSN;
            EmpName = empName;
            EmpPhone = empPhone;
            EmpAddress = empAddress;
            EmpGender = empGender;
            EmpPosition = empPosition;
        }

        public EmployeeModel(string empSSN, string empName, string empPhone, string empAddress, string empGender, string empPosition)
        {
            EmpSSN = empSSN;
            EmpName = empName;
            EmpPhone = empPhone;
            EmpAddress = empAddress;
            EmpGender = empGender;
            EmpPosition = empPosition;
        }

        public EmployeeModel()
        {

        }
    }
}
