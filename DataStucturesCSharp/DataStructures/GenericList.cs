using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DataStucturesCSharp.DataStructures.Interfaces;

namespace DataStucturesCSharp.DataStructures {
    public class GenericList<T> : IList<T> {

        // Array holding items of type T.
        private T[] Array { get; set; }
        // Capacity of Array before having to resize the array.  
        private int Capacity { get; set; }
        // How many items are in the array at the moment.
        bool ICollection<T>.Remove(T item) {
            throw new NotImplementedException();
        }

        public int Count { get; private set; }
        public bool IsReadOnly { get; private set; }

        public GenericList() : this(10) {}

        public GenericList(int capacity) {
            
            Capacity = capacity;
            Array = new T[Capacity];
            Count = 0;
        }

        private int Compare(T x, T y) {
            throw new NotImplementedException();
        }

        private bool CheckIfListIsFull() {
            return Count == Capacity;
        }

        private void ResizeArray() {
            var currentArray = Array;
            var newArray = new T[currentArray.Length * 2];
            currentArray.CopyTo(newArray, 0);
            Array = newArray;
        }

        public void Add(T item) {

            if (Count >= Capacity) 

            // Adds the item to the array at the current Count.
            Array[Count] = item;
            // Increment Count.
            Count++;
        }

        public void CopyTo(T[] array, int arrayIndex) {
            throw new NotImplementedException();
        }

        public void Remove(T item) {
            throw new NotImplementedException();
        }

        public bool Contains(T item) {
            throw new NotImplementedException();
        }

        public void Clear() {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator() {
            throw new NotImplementedException();
        }

        public bool IsEmpty() {
            return false;
        }



        public int IndexOf(T item) {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item) {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index) {
            throw new NotImplementedException();
        }

        public T this[int index] {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}
