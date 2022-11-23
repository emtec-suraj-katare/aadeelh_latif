using Dapper;
using DapperAssignment.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DapperAssignment.Repositories
{
    public class EmployeeRepository
    {
        
        public IConfiguration Configuration { get; }

        public EmployeeRepository(IConfiguration configuration)
        {
            Configuration = configuration;
            
        }

        public IEnumerable<Employee> Get()
        {
            string sql = "select * from Employee";
            using (var connetion = new SqlConnection(Configuration.GetConnectionString("DefaultConnection")))
            {
                connetion.Open();
                var result = connetion.Query<Employee>(sql);
                return result.ToList();
            }
        }
        [HttpPost]
        public int Create(Employee employee)
        {

            var sql = "Insert into Employee (First_Name,Last_Name,Age,Salary,Department) VALUES (@First_Name,@Last_Name,@Age,@Salary,@Department)";

            using (var connection = new SqlConnection(Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = connection.Execute(sql, employee);
                return result;
            }
        }

        public int Update(Employee employee, int id)
        {
            var sql = $"UPDATE Employee SET First_Name = @First_Name,Last_Name = @Last_Name, Age=@Age ,Salary=@Salary,Department=@Department WHERE Id = @Id";
            using (var connection = new SqlConnection(Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = connection.Execute(sql, employee);
                return result;
            }
        }

        public int Delete(int id)
        {
            var sql = "DELETE FROM Employee WHERE Id = @Id";
            using (var connection = new SqlConnection(Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = connection.Execute(sql, new { Id = id });
                return result;
            }
        }
    }
}
