using System.Linq;
using Xunit;
using static PrimeFactor002.PrimeFactors;

namespace PrimeFactor002Test
{
    public class PrimeFactorsTest
    {
        [Fact]
        public void TestOne()
        {
            Assert.Equal(Enumerable.Empty<int>(), Generate(1));
        }
    }
}
