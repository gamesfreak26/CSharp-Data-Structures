using System;
using System.Collections.Generic;
using System.Text;
using CodeKatas.CodeKatas;
using NUnit.Framework;
using Shouldly;

namespace TestProject {
    public class BinarySearchTests {

        [Test]
        public void Test001() {
            var arrayInt = new int[1];
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(3);
            num.ShouldBe(-1);
        }

        [Test]
        public void Test002() {
            var arrayInt = new[] {
                1
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(3);
            num.ShouldBe(-1);
        }

        [Test]
        public void Test003() {
            var arrayInt = new[] {
                1
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(1);
            num.ShouldBe(0);
        }

        [Test]
        public void Test004() {
            var arrayInt = new[] {
                1, 3, 5
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(1);
            num.ShouldBe(0);
        }

        [Test]
        public void Test005() {
            var arrayInt = new[] {
                1, 3, 5
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(3);
            num.ShouldBe(1);
        }

        [Test]
        public void Test006() {
            var arrayInt = new[] {
                1, 3, 5
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(5);
            num.ShouldBe(2);
        }

        [Test]
        public void Test007() {
            var arrayInt = new[] {
                1, 3, 5
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(0);
            num.ShouldBe(-1);
        }

        [Test]
        public void Test008() {
            var arrayInt = new[] {
                1, 3, 5
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(2);
            num.ShouldBe(-1);
        }

        [Test]
        public void Test009() {
            var arrayInt = new[] {
                1, 3, 5
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(4);
            num.ShouldBe(-1);
        }

        [Test]
        public void Test010() {
            var arrayInt = new[] {
                1, 3, 5
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(6);
            num.ShouldBe(-1);
        }

        [Test]
        public void Test011() {
            var arrayInt = new[] {
                1, 3, 5, 7
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(1);
            num.ShouldBe(0);
        }

        [Test]
        public void Test012() {
            var arrayInt = new[] {
                1, 3, 5, 7
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(3);
            num.ShouldBe(1);
        }

        [Test]
        public void Test013() {
            var arrayInt = new[] {
                1, 3, 5, 7
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(5);
            num.ShouldBe(2);
        }

        [Test]
        public void Test014() {
            var arrayInt = new[] {
                1, 3, 5, 7
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(7);
            num.ShouldBe(3);
        }

        [Test]
        public void Test015() {
            var arrayInt = new[] {
                1, 3, 5, 7
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(0);
            num.ShouldBe(-1);
        }

        [Test]
        public void Test016() {
            var arrayInt = new[] {
                1, 3, 5, 7
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(2);
            num.ShouldBe(-1);
        }

        [Test]
        public void Test017() {
            var arrayInt = new[] {
                1, 3, 5, 7
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(4);
            num.ShouldBe(-1);
        }

        [Test]
        public void Test018() {
            var arrayInt = new[] {
                1, 3, 5, 7
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(6);
            num.ShouldBe(-1);
        }

        [Test]
        public void Test019() {
            var arrayInt = new[] {
                1, 3, 5, 7
            };
            var bsa = new BinarySearchAlgorithm(arrayInt);
            var num = bsa.Search1(8);
            num.ShouldBe(-1);
        }
    }
}

/*
  assert_equal(-1, chop(0, [1, 3, 5, 7]))
  assert_equal(-1, chop(2, [1, 3, 5, 7]))
  assert_equal(-1, chop(4, [1, 3, 5, 7]))
  assert_equal(-1, chop(6, [1, 3, 5, 7]))
  assert_equal(-1, chop(8, [1, 3, 5, 7]))

 */