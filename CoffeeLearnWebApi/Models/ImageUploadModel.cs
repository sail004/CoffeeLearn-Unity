namespace CoffeeLearnWebApi.Models
{
    public class ImageUploadModel
    {
        public IFormFile ImageFile { get; set; }

        public string DocumentsType { get; set; }

        public int DocumentNumber { get; set; }
    }
}