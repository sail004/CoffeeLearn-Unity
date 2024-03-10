using CoffeeLearnWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;


namespace CoffeeLearnWebApi.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentResoursesController: Controller
    {
        readonly CoffeeLearnDbContext _dbContext;

        public DocumentResoursesController(CoffeeLearnDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        [Authorize]
        [HttpPost]
        [Route("upload")]
        public async Task<IActionResult> UploadImage([FromForm] ImageUploadModel model)
        {
            if (model == null || model.ImageFile == null || model.ImageFile.Length == 0)
                return BadRequest("Invalid image");

            using (var memoryStream = new MemoryStream())
            {
                await model.ImageFile.CopyToAsync(memoryStream);
                var image = new DocumentResourses
                {
                    FileName = model.ImageFile.FileName,
                    Data = memoryStream.ToArray(),
                    ResourseTypeId = 1,
                    Id = 1
                };

                _dbContext.DocumentResourses.Add(image);
                
                await _dbContext.SaveChangesAsync();
                
               
                return Ok(new { image.Id });
            }

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetImage(int id)
        {
            var image = await _dbContext.DocumentResourses.FindAsync(id);

            if (image == null)
            {
                return NotFound();
            }

            return File(image.Data, "image/jpeg");
        }



    }

}
