using ADO.NET_ASSIGNMENT.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET_ASSIGNMENT.Repositories
{
    public class EmployeeRepository
    {
        private readonly string _connectionString;
        public IConfiguration Configuration { get; }

        public EmployeeRepository(IConfiguration configuration)
        {
            Configuration = configuration;
            _connectionString = Configuration["ConnectionStrings:DefaultConnection"];
        }
        public IEnumerable<Employee> Get()
        {
            var employees = new List<Employee>();
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = "Select * from Employee";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                var employee = new Employee()
                {
                    Id = Convert.ToInt32(dataTable.Rows[i]["Id"]),
                    First_Name = dataTable.Rows[i]["First_Name"].ToString(),
                    Last_Name = dataTable.Rows[i]["Last_Name"].ToString(),
                    Age = Convert.ToInt32(dataTable.Rows[i]["Age"]),
                    Salary = Convert.ToDecimal(dataTable.Rows[i]["Salary"]),
                    Department= dataTable.Rows[i]["Department"].ToString(),
                };
                employees.Add(employee);
            }

            return employees;
        }
        public bool Create(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = $"Insert into Employee (First_Name, Last_Name, Age,Salary,Department) Values ('{employee.First_Name}', " +
                             $"'{employee.Last_Name}', '{employee.Age}', '{employee.Salary}', '{employee.Department}')";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return true;
            }
        }
       
        public bool Update(Employee employee, int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = $"Update Employee SET First_Name='{employee.First_Name}', Last_Name='{employee.Last_Name}', Age='{employee.Age}',Salary='{employee.Age}' ,Department = '{employee.Department}' Where Id='{id}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                return true;
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = $"Delete From Employee Where Id='{id}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                return true;
            }
        }

    }
}
