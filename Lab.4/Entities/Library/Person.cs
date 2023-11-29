using Lab._4.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._4.Entities.Library
{
    public class Person : IEntity<long>, IHaveDate
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public float Age { get; set; }
        public List<IBook> Books { get; set; } = new List<IBook>();

        public long Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
