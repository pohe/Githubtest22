﻿namespace Githubtest22.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int id, string name) //jeg har lavet en name parameter
        {
            Name = name; 
            Id = id;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
