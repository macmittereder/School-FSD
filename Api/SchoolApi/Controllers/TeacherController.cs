using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Api.Data;
using School.Api.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Controllers
{
    [Route("api/teachers")]
    [ApiController]
    public class TeacherController : Controller
    {
        private readonly SchoolDbContext School;

        public TeacherController(SchoolDbContext School)
        {
            this.School = School;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TeacherEntity entity)
        {
            School.Add(entity);
            await School.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] TeacherEntity entity)
        {
            School.Remove(entity);
            await School.SaveChangesAsync();
            return Ok();
        }
    }
}
