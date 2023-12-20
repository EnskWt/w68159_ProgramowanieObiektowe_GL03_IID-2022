using Lab._56.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._56.RepositoryContracts.Base
{
    public interface IBaseRepository<T, TEntity> where T: IEntity<TEntity>
    {
        void Create();

        void Update();

        void Delete();

        void Get();

        List<int> GetAll();
    }
}
