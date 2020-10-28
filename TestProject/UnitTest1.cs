using DataStucturesCSharp.DataStructures;
using NUnit.Framework;
using Shouldly;

namespace TestProject {
    public class Tests {

        
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void AddItemToList() {
            var _list = new GenericList<int> {
                0
            };
            var numberOfElements = _list.Count;

            numberOfElements.ShouldBe(1);
        }

        [Test]
        public void AddMoreItemsThanCapacityToList() {
            GenericList<int> _list = new GenericList<int>();
            for (var i = 0; i < 15; i++) {
                _list.Add(i);
            } 
            _list.Count.ShouldBe(15);
        }
    }
}