using System.Data;

namespace CoffeeLearnWebApi.Models
{
    public class Training
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
