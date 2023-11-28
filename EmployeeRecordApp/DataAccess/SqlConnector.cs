using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using EmployeeRecordApp.Models;

namespace EmployeeRecordApp.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public EmployeeModel CreateEmployee(EmployeeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("EmployeeDB")))
            {
                var p = new DynamicParameters();
                p.Add("@empSSN", model.EmpSSN);
                p.Add("@empName", model.EmpName);
                p.Add("@empPhone", model.EmpPhone);
                p.Add("@empAddress", model.EmpAddress);
                p.Add("@empGender", model.EmpGender);
                p.Add("@empPosition", model.EmpPosition);
                p.Add("@empId", 0 , dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spEmployees_Insert",p, commandType: CommandType.StoredProcedure);

                model.EmpId = p.Get<int>("@empId");

                return model;
            }
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            List<EmployeeModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("EmployeeDB")))
            { 
                output = connection.Query<EmployeeModel>("spEmployees_GetAll").ToList();
                
            }
            return output;
        }

        public EmployeeModel GetEmployeeBySSN(string empSSN)
        {
            var output = new EmployeeModel();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("EmployeeDB")))
            {
                var p = new DynamicParameters();
                p.Add("@empSSN", empSSN);

                output = connection.Query<EmployeeModel>("spEmployee_GetBySSN",p,commandType: CommandType.StoredProcedure).FirstOrDefault();
                
            }
            return output;
        }

        public void UpdateEmployee(EmployeeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("EmployeeDB")))
            {
                var p = new DynamicParameters();
                p.Add("@empId", model.EmpId);
                p.Add("@empSSN", model.EmpSSN);
                p.Add("@empName", model.EmpName);
                p.Add("@empPhone", model.EmpPhone);
                p.Add("@empAddress", model.EmpAddress);
                p.Add("@empGender", model.EmpGender);
                p.Add("@empPosition", model.EmpPosition);

                connection.Execute("spEmployee_Update", p, commandType: CommandType.StoredProcedure);

            }
        }
    }
}
