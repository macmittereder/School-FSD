using HotChocolate.Language;
using Microsoft.AspNetCore.Mvc;
using School.Api.Data;
using School.Api.Data.Entities;
using System.Threading.Tasks;

namespace School.Api.Controllers
{
    public class StudentController : Controller
    {
        private readonly SchoolDbContext School;

        public StudentController(SchoolDbContext School)
        {
            this.School = School;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] StudentEntity entity)
        {
            School.Add(entity);
            await School.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] StudentEntity entity)
        {
            School.Remove(entity);
            await School.SaveChangesAsync();
            return Ok();
        }
    }
}
