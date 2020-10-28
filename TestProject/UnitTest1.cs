using System;
using DataStucturesCSharp.DataStructures;
using NUnit.Framework;
using Shouldly;

namespace TestProject {
    public class Tests {


        [SetUp]
        public void Setup() { }

        [Test]
        public void AddItemToList() {
            var list = new GenericList<int> {
                0
            };

            list.ShouldNotBeEmpty();
            list.Count.ShouldBe(1);
        }

        [Test]
        public void AddMoreItemsThanCapacityToList() {
            var numberOfItemsToInsert = 11;
            var list = new GenericList<int>(10);

            for (var i = 0; i < numberOfItemsToInsert; i++) {
                list.Add(i);
            }

            list.ShouldNotBeEmpty();
            list.Count.ShouldBe(numberOfItemsToInsert);
        }

        [Test]
        public void RemoveElement() {
            var list = new GenericList<int> {
                0
            };

            list.RemoveAt(0);
            
            list.ShouldBeEmpty();
            list.Count.ShouldBe(0);
        }

        [Test]
        public void CheckIsEmpty() {
            var list = new GenericList<int>();

            var empty = list.IsEmpty();

            empty.ShouldBeTrue();
        }

        [Test]
        public void CheckIsEmptyWhenNotEmpty() {
            var list = new GenericList<int> {
                0
            };

            var empty = list.IsEmpty();

            empty.ShouldBeFalse();
        }

        [Test]
        public void ClearList() {
            var list = new GenericList<int> {
                0, 
                1
            };

            list.Clear();

            list.Count.ShouldBe(0);
        }
    }
}