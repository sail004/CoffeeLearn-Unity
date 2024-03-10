﻿using System.ComponentModel.DataAnnotations;

namespace CoffeeLearnWebApi.Models
{
    public class Documents
    {
        [Key]
        public int DocId { get; set; }
        public string DocName { get; set; }
        public string UserLogin { get; set; }
        public int IdDocumentResourse { get; set; }
        public User User { get; set; }
    }
}
