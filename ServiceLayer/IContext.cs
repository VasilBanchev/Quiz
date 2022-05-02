using System;
using System.Collections.Generic;

namespace ServiceLayer
{
    public interface IContext<T, K>
    {
        void Create(T item);

        T Read(K key);

        IEnumerable<T> ReadAll();

        void Update(T item);

        void Delete(K key);
    }
}
