namespace CoffeeLearnWebApi.Models
{
    public class DocumentResourses
    {
        public int Id { get; set; }
        public int ResourseTypeId { get; set; }
        public string FileName { get; set; }
        public byte[] Data { get; set; }



    }
}

