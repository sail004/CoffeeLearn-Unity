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
                UserId = _dbContext.Users.FirstOrDefault(user => user.Login == model.UserLogin).Id,
                IdDocumentResourse = model.IdDocumentResourse,
                DocumentNumber = int.Parse(model.DocumentNumber)

            };

            _dbContext.Documents.Add(newDocument);

            await _dbContext.SaveChangesAsync();


            return Ok(); 
        }

        [Route("getOneDocument/{id}")]
        public IActionResult GetOneDocument([FromRoute] string id)
        {

            var document = _dbContext.Documents.FirstOrDefault(document => document.DocId == int.Parse(id));

            return Ok(document);

        }
        [Route("deleteDocument/{id}")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDocument(int id)
        {
            try
            {
                var document = await _dbContext.Documents.FindAsync(id);

                if (document == null)
                {
                    return NotFound();
                }

                _dbContext.Documents.Remove(document);
                await _dbContext.SaveChangesAsync();

                return NoContent(); // HTTP 204: Успешное удаление
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Произошла ошибка при удалении документа: {ex.Message}");
            }
        }
    }


}
