using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    [TestFixture]
    class TestsFor1
    {
        [TestCase]
        public void TestZero()
        {
            Assert.AreEqual(FizzBuzz.FizzBuzz1(0), "FizzBuzz");
        }
        [TestCase]
        public void TestSimple()
        {
            Assert.AreEqual(FizzBuzz.FizzBuzz1(1), "1");
            Assert.AreEqual(FizzBuzz.FizzBuzz1(2), "2");
            Assert.AreEqual(FizzBuzz.FizzBuzz1(3), "Fizz");
            Assert.AreEqual(FizzBuzz.FizzBuzz1(5), "Buzz");
        }
        [TestCase]
        public void TestBigNumbers()
        {
            Assert.AreEqual(FizzBuzz.FizzBuzz1(111), "Fizz");
            Assert.AreEqual(FizzBuzz.FizzBuzz1(120), "FizzBuzz");
            Assert.AreEqual(FizzBuzz.FizzBuzz1(500), "Buzz");
        }
    }
    [TestFixture]
    class TestsFor2
    {
        [TestCase]
        public void TestZero()
        {
            Assert.AreEqual(FizzBuzz.FizzBuzz2(0), "FizzBuzz");
        }
        [TestCase]
        public void TestSimple()
        {
            Assert.AreEqual(FizzBuzz.FizzBuzz2(11), "11");
            Assert.AreEqual(FizzBuzz.FizzBuzz2(4), "4");
            Assert.AreEqual(FizzBuzz.FizzBuzz2(33), "Fizz");
            Assert.AreEqual(FizzBuzz.FizzBuzz2(30), "FizzBuzz");
        }
        [TestCase]
        public void TestBigNumbers()
        {
            Assert.AreEqual(FizzBuzz.FizzBuzz2(1000), "Buzz");
            Assert.AreEqual(FizzBuzz.FizzBuzz2(240), "FizzBuzz");
            Assert.AreEqual(FizzBuzz.FizzBuzz2(333), "Fizz");
        }
    }

}
