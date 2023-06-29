using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface IDB<T, U>
    {
        void Create(T item);
        T Read(U key);
        IEnumerable<T> ReadAll();
        void Update(T item);
        void Delete(U key);
    }
}
