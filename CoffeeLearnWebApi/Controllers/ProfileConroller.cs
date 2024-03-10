using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CoffeeLearnWebApi.Controllers

{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : Controller
    {
        readonly CoffeeLearnDbContext _dbContext;
        
        public ProfileController(CoffeeLearnDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("get/{login}")]
        public IActionResult GetLogin([FromRoute] string login)
        {
            var user = _dbContext.Users.FirstOrDefault(user => user.Login == login);
            return Ok(user);
        }

    }
}
