using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeLearnWebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController: Controller
    {
        readonly CoffeeLearnDbContext _dbContext;
        public CoursesController(CoffeeLearnDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("getCourse")]
        public IActionResult GetCourse()
        {
            var courses = _dbContext.Courses;

            return Ok(courses);
        }
        [Route("getOneCourse/{courseId}")]
        public IActionResult GetOneCourse(string courseId)
        {
            var courses = _dbContext.Courses.FirstOrDefault(course => course.Id == int.Parse(courseId));

            return Ok(courses);
        }

    }
}
