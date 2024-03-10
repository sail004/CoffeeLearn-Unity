﻿namespace AuthExample2.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public ICollection<Training> Trainings { get; set; }
    }
}