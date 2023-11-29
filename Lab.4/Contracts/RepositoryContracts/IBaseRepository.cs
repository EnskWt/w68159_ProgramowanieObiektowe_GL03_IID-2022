using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._4.Contracts.RepositoryContracts
{
    public interface IBaseRepository<T, TEntity> where T: IEntity<TEntity>
    {
        void Create();

        void Update();

        void GetAll();

        void Get();

        void Delete();
    }
}
