using ADO.NET_ASSIGNMENT.Model;
using ADO.NET_ASSIGNMENT.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ADO.NET_ASSIGNMENT.Controllers
{
    [ApiController]
    [Route("employee")]
    public class EmployeeController : Controller
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeController(IConfiguration configuration)
        {
            _employeeRepository = new EmployeeRepository(configuration);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_employeeRepository.Get());
        }

        

        [HttpPost]
        public IActionResult Post(Employee employee)
        {
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
