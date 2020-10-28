using System.Collections.Generic;

namespace DataStucturesCSharp.DataStructures.Interfaces {
    public interface IGenericCollection<T> {
        int Count { get; }
        void Add(T item);
        void Remove(T item);
        bool Contains(T item);
        void Clear();
        IEnumerator<T> GetEnumerator();

    }
}
