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
        public int Count { get; private set; }
        public bool IsReadOnly => false;

        protected T OtherValue;

        public GenericList() : this(10) {}

        public GenericList(int capacity) {
            Capacity = capacity;
            Array = new T[Capacity];
            Count = 0;
        }

        public T this[int index] {
            get => Array[index];
            set => Array[index] = value;
        }

        private bool CheckIfListIsFull() {
            return Count == Capacity;
        }

        private void ResizeArray() {
            var currentArray = Array;
            var newCapacity = currentArray.Length * 2;
            
            var newArray = new T[newCapacity];
            currentArray.CopyTo(newArray, 0);
            
            Array = newArray;
            Capacity = newCapacity;
        }

        public void Add(T item) {

            var isFull = CheckIfListIsFull();

            if (isFull) ResizeArray();

            // Adds the item to the array at the current Count.
            Array[Count] = item;
            // Increment Count.
            Count++;
        }

        public void Insert(int index, T item) {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex) {
            Array.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item) {
            var index = IndexOf(item);
            if (index == -1) return false;

            RemoveAt(IndexOf(item));
            return true;
        }

        public bool Contains(T item) {

            for (var i = 0; i < Count; i++) {
                if (Array[i].Equals(item)) {
                    return true;
                }
            }

            return false;
        }

        public void Clear() {
            Count = 0;
        }

        public IEnumerator<T> GetEnumerator() {
            for (var i = 0; i < Count; i++) {
                yield return Array[i];
            }
        }

        public bool IsEmpty() {
            return Count == 0;
        }
        
        public int IndexOf(T item) {
            for (var i = 0; i < Count; i++) {
                if (Array[i] == null) return -1;

                if (Array[i].Equals(item)) {
                    return i;
                }
            }
            return -1;
        }

        // Iterates through the array and 
        // move everything 
        public void RemoveAt(int index) {
            if (index < 0 || index > Count) 
                throw new IndexOutOfRangeException();

            if (IsReadOnly) throw new NotSupportedException();

            for (int i = index; i < Count - 1; i++) {
                Array[i] = Array[i + 1];
            }

            Count--;
            
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}
