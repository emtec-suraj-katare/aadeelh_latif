using EntityFrameworkCore.Context;
using EntityFrameworkCore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Controllers
{
    [ApiController]
    [Route("Student")]
    public class StudentController : Controller
    {
        private IApplicationDbContext _context;
        public StudentController(IApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Post(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChanges();
            return Ok(1);
        }
        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            var students = await _context.Students.ToListAsync();
            if (students == null)
                return NotFound();
            return Ok(students);
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var student = await _context.Students.Where(n => n.Id == id).FirstOrDefaultAsync();
            if (student == null)
                return NotFound();
            return Ok(student);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _context.Students.Where(n => n.Id == id).FirstOrDefaultAsync();
            if (student == null)
                return NotFound();
            _context.Students.Remove(student);
            await _context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Student studentToUpdate)
        {
            var student = await _context.Students.Where(n => n.Id == id).FirstOrDefaultAsync();
            if (student == null)
                return NotFound();

            student.Name = studentToUpdate.Name;
            student.City = studentToUpdate.City;
            student.PinCode = studentToUpdate.PinCode;
            await _context.SaveChanges();
            return Ok();
        }
    }
}
