using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeLearnWebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class PracticeTestController:Controller
    {
        readonly CoffeeLearnDbContext _dbContext;
        public PracticeTestController(CoffeeLearnDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [Route("getTest/{structureId}")]
        public IActionResult GetTest(string structureId)
        {
            var test = _dbContext.practiceTests.Where(practiceTest => practiceTest.StructureId == int.Parse(structureId)); ;

            return Ok(test);
        }
    }
}
