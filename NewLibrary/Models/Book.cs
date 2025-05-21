using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibrary.Models
{
    class Book
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Author { get; set; }
        public int Id { get; set; }
       
        public Book(string name, int age, string author, int id)
        {
            Name = name;
            Age = age;
            Author = author;
            Id = id;

        }
        public override string ToString()
        {
            return $"ID: {Id}, Название: {Name}, Автор: {Author}, Год: {Age}";
        }






    }
}
