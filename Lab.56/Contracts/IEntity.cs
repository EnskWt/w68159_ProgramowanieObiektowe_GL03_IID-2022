using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._56.Contracts
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
