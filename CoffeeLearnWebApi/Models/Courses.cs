using Microsoft.AspNetCore.SignalR;
using System.Data;

namespace CoffeeLearnWebApi.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
