using System;
using Xunit;
using System.Linq;

namespace key_short_calc.test
{
    public class UnitTestEnglish
    {
        private ShortCalaculator calculator= new ShortCalaculator(new PinYinEncoder());

        [Fact]
        public void Testava()
        {
            var actual = new string(calculator.Calc("ava").ToArray());
            Assert.True(actual.StartsWith("AV") && actual.Length == 26);
        }

        [Fact]
        public void TestAva()
        {
            var actual = new string(calculator.Calc("Ava").ToArray());
            Assert.True(actual.StartsWith("AV") && actual.Length == 26);
        }

        [Fact]
        public void TestaVa()
        {
            var actual = new string(calculator.Calc("aVa").ToArray());
            Assert.True(actual.StartsWith("AV") && actual.Length == 26);
        }

        [Fact]
        public void TestavB()
        {
            var actual = new string(calculator.Calc("avB").ToArray());
            Assert.True(actual.StartsWith("ABV") && actual.Length == 26);
        }

        [Fact]
        public void TestSpace()
        {
            var actual = new string(calculator.Calc("sanoba witch").ToArray());
            // ?
            Assert.True(actual.StartsWith("SWANOBITCH") && actual.Length == 26);
        }

        [Fact]
        public void TestSymBol()
        {
            var actual = new string(calculator.Calc("primal×hearTs").ToArray());
            // ?
            Assert.True(actual.StartsWith("PHTRIMALES") && actual.Length == 26);
        }
    }
}
