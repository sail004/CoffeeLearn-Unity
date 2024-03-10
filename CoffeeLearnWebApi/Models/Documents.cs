
using System.ComponentModel.DataAnnotations;

namespace AuthExample2.Models
{
    public class Documents
    {
        [Key]
        public int DocId { get; set; }
        public string DocName { get; set; }
        public string UserLogin { get; set; }
        public User User { get; set; }
    }
}
