using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeLearnWebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CourseStructureController: Controller
    {
        readonly CoffeeLearnDbContext _dbContext;
        public CourseStructureController(CoffeeLearnDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("getCourseStructure/{courseId}")]
        public IActionResult GetCourseStructure(string courseId)
        {
            var courseStructure = _dbContext.CourseStructures.Where(courseStruct => courseStruct.CourseId == int.Parse(courseId));

            return Ok(courseStructure);
        }
    }
}
