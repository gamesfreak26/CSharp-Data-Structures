using System;
using CodeKatas.CodeKatas;

namespace CodeKatas {
    class Program {
        static void Main(string[] args) {
            var arrayOfNumbers = new int[] {
                10, 20, 23, 37, 42, 59, 64, 73, 80, 97
            };
            var binarySearchAlgorithm = new BinarySearchAlgorithm(arrayOfNumbers);
            var numberFound = binarySearchAlgorithm.Search1(64);
        }
    }
}
