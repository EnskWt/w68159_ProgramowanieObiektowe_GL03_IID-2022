using Lab._56.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._56.Repositories.Book
{
    public class BookRepository : IBookRepository
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public List<int> GetAll()
        {
            return new List<int> { 1, 2, 3, 4, 5};
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
