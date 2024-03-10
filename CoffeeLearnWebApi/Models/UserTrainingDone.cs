namespace CoffeeLearnWebApi.Models
{
    public class UserTrainingDone
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int TrainingId { get; set; }
        public Training Training { get; set; }
        public DateTime DateDone { get; set; }
    }
}
