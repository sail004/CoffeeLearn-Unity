using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace AuthExample2.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentController: Controller
    {
        AuthExampleContext authExampleContext = new AuthExampleContext();
        [Route("getDocument/{login}")]
        public IActionResult GetDocument([FromRoute] string login)
        {
            var user = authExampleContext.Documents.FirstOrDefault(user => user.UserLogin == login);
            return Ok(user);
        }
    }
}
