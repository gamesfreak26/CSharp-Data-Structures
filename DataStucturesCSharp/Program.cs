using System;
using System.Collections.Generic;
using DataStucturesCSharp.DataStructures;

namespace DataStucturesCSharp {
    class Program {
        static void Main(string[] args) {
            
            GenericLinkedList<int> linkedListOfNumbers = new GenericLinkedList<int>();

            for (int i = 0; i < 5; i++) {
                linkedListOfNumbers.Add(i);
            }

            foreach (var number in linkedListOfNumbers) {
                Console.WriteLine(number);
            }


            List<string> stringlist = new List<string>();
        }
    }
}
