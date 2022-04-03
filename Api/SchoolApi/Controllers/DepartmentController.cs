using HotChocolate.Language;
using Microsoft.AspNetCore.Mvc;
using School.Api.Data;
using School.Api.Data.Entities;
using System.Threading.Tasks;

namespace School.Api.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly SchoolDbContext School;

        public DepartmentController(SchoolDbContext School)
        {
            this.School = School;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DepartmentEntity entity)
        {
            School.Add(entity);
            await School.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DepartmentEntity entity)
        {
            School.Remove(entity);
            await School.SaveChangesAsync();
            return Ok();
        }
    }
}
