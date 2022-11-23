using DapperAssignment.Model;
using DapperAssignment.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DapperAssignment.Controllers
{
    [ApiController]
    [Route("Employee")]
    public class DapperController : Controller
    {
        private readonly EmployeeRepository _employeeRepository;

        public DapperController(IConfiguration configuration)
        {
            _employeeRepository = new EmployeeRepository(configuration);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_employeeRepository.Get());
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
         /*   var employee = new Employee(); */
            return Ok(_employeeRepository.Create(employee));
        }


        [HttpPut]
        public IActionResult Put([FromBody] Employee employee, int id)
        {
            return Ok(_employeeRepository.Update(employee, id));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_employeeRepository.Delete(id));
        }
    }
}
