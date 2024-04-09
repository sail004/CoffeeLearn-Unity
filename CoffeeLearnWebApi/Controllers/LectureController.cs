using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeLearnWebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class LectureController:Controller
    {
        readonly CoffeeLearnDbContext _dbContext;
        public LectureController(CoffeeLearnDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("getLecture/{structureId}")]
        public IActionResult GetLecture(string structureId)
        {
            var lecture = _dbContext.Lecture.Where(lect => lect.StructureId == int.Parse(structureId));

            return Ok(lecture);
        }

        [Route("getLectureContent/{lectureId}")]
        public IActionResult GetLectureContent(int lectureId)
        {
            var lecture = _dbContext.Lecture.FirstOrDefault(lect => lect.Id == lectureId);

            return Ok(lecture.Content);
        }
    }

}
