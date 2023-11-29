using Lab._56.Entities.Library;
using Lab._56.RepositoryContracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._56.RepositoryContracts
{
    public interface IBookRepository : IBaseRepository<Book, Guid>
    {
    }
}
