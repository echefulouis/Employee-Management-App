using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeRecordApp.Models;

namespace EmployeeRecordApp.DataAccess
{
    public interface IDataConnection
    {
        EmployeeModel CreateEmployee(EmployeeModel model);

        List<EmployeeModel> GetAllEmployees();

        void UpdateEmployee(EmployeeModel model);

        EmployeeModel GetEmployeeBySSN(string empSSN);
    }
}
