namespace CoffeeLearnWebApi.Models
{
    public class Progress
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public decimal ProgressPercent { get; set; }
        public DateTime DateDone { get; set; }
    }
}
