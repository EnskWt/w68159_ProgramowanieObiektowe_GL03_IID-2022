using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._4.Contracts
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
