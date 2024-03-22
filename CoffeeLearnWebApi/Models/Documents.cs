using System.ComponentModel.DataAnnotations;

namespace CoffeeLearnWebApi.Models
{
    public class Documents
    {
        [Key]
        public int DocId { get; set; }
        public string DocName { get; set; }
        public int UserId { get; set; }
        public int IdDocumentResourse { get; set; }

        public int DocumentNumber { get; set; }
        //public User User { get; set; }
    }
}
