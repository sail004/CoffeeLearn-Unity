using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CoffeeLearnWebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentController : Controller
    {
        readonly CoffeeLearnDbContext _dbContext;

        public DocumentController(CoffeeLearnDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("getDocument/{login}")]
        public IActionResult GetDocument([FromRoute] string login)
        {
            var user = _dbContext.Documents.FirstOrDefault(user => user.UserLogin == login);
            return Ok(user);
        }
    }
}
