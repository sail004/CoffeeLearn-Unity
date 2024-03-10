using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
namespace AuthExample2.Controllers

{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController: Controller
    {
        AuthExampleContext authExampleContext = new AuthExampleContext();

        [Route("get/{login}")]
        public IActionResult GetLogin([FromRoute]string login)
        {
            var user = authExampleContext.Users.FirstOrDefault(user => user.Login == login);
            return Ok(user);
        }

    }
}
