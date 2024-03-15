using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CoffeeLearnWebApi.Models;
using Microsoft.EntityFrameworkCore;

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

            var user = _dbContext.Users.FirstOrDefault(user => user.Login == login);

            var document = _dbContext.Documents.Where(document => document.UserId == user.Id);

            return Ok(document);
        }
        [Route("addDocument")]
        [HttpPost]
        public async Task<IActionResult> UploadDocument([FromForm] DocumentUploadModel model)
        {
            var newDocument = new Documents
            {
                DocName = model.DocumentType, 
                UserId = _dbContext.Users.FirstOrDefault(user =>user.Login == model.UserLogin).Id,
                IdDocumentResourse = model.IdDocumentResourse
            };

            _dbContext.Documents.Add(newDocument);

            await _dbContext.SaveChangesAsync();


            return Ok(); 
        }

    }
}
