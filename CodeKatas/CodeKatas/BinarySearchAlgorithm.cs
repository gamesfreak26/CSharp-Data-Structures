using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKatas.CodeKatas {

    // Given a sorted array of n elements, 
    // find a number k
    public class BinarySearchAlgorithm {
        public int[] SortedListContents { get; set; }

        public BinarySearchAlgorithm(int[] array) {
            SortedListContents = array;
        }

        public int Search1(int targetNumber) {

            var left = 0;
            var right = SortedListContents.Length - 1;
            var middle = 0;

            while (left <= right) {
                if (left > right) {
                    return -1;
                }
                middle = (left + (right-1)) / 2;

                if (SortedListContents[middle] == targetNumber) {
                    return middle;
                }

                if (SortedListContents[middle] < targetNumber) {
                    left = middle + 1;
                }
                else right = middle - 1;
            }
            return -1;
        }

        // Thoughts:
        // 1.  Errors:
        // * Initially right was 10, the loop was infinite.  
        // * Then, it wasn't changing right so it was only looking at a specific part of the list 
        // infinitely.  
        // * Half of the tests provided are going 
        // into infinite loops. 

        // 2. What can you say about the relative merits of the various techniques you’ve chosen?
        // Easy to read.  Not as memory saving as 
        // recursion. 
    }
}
