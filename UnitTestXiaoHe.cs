using System;
using Xunit;
using System.Linq;

namespace key_short_calc.test
{
    public class UnitTestPinYin
    {
        private ShortCalaculator calculator= new ShortCalaculator(new PinYinEncoder());

        [Fact]
        public void TestChineseWord()
        {
            var actual = new string(calculator.Calc("嘉然").ToArray());
            Assert.True(actual.StartsWith("JR") && actual.Length == 26);
        }

        [Fact]
        public void TestChineseEnglish()
        {
            var actual = new string(calculator.Calc("嘉然diaNa").ToArray());
            Assert.True(actual.StartsWith("JRDNIA") && actual.Length == 26);
        }

        [Fact]
        public void TestEnglishChinese()
        {
            var actual = new string(calculator.Calc("diaNa嘉然").ToArray());
            Assert.True(actual.StartsWith("DNJRIA") && actual.Length == 26);
        }
    }
}
