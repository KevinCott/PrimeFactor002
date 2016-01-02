using System.Collections.Generic;
using System.Linq;
using Xunit;
using static PrimeFactor002.PrimeFactors;

namespace PrimeFactor002Test
{
    public class PrimeFactorsTest
    {

        [Fact]
        public void TestTwoHundredFiftyTwo()
        {
            Assert.Equal(new List<int> { 2, 2, 3, 3, 7 }, Generate(252));
        }

        [Fact]
        public void TestNine()
        {
            Assert.Equal(new List<int> { 3, 3 }, Generate(9));
        }

        [Fact]
        public void TestEight()
        {
            Assert.Equal(new List<int> { 2, 2, 2 }, Generate(8));
        }

        [Fact]
        public void TestSeven()
        {
            Assert.Equal(new List<int> { 7 }, Generate(7));
        }

        [Fact]
        public void TestSix()
        {
            Assert.Equal(new List<int> { 2, 3 }, Generate(6));
        }

        [Fact]
        public void TestFive()
        {
            Assert.Equal(new List<int> { 5 }, Generate(5));
        }

        [Fact]
        public void TestFour()
        {
            Assert.Equal(new List<int> { 2, 2 }, Generate(4));
        }

        [Fact]
        public void TestThree()
        {
            Assert.Equal(new List<int> { 3 }, Generate(3));
        }

        [Fact]
        public void TestTwo()
        {
            Assert.Equal(new List<int> { 2 }, Generate(2));
        }

        [Fact]
        public void TestOne()
        {
            Assert.Equal(Enumerable.Empty<int>(), Generate(1));
        }
    }
}
