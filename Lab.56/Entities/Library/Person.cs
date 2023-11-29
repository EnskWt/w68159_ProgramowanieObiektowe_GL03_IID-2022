using Lab._56.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._56.Entities.Library
{
    public class Person : IEntity<int>, IHaveDate
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public int Age { get; set; } 
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
