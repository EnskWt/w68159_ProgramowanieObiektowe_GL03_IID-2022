using Lab._4.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._4.Entities.Library
{
    public class Book : IEntity<Guid>, IHaveDate
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime Date { get; set; } = DateTime.Now;
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
    }
}
