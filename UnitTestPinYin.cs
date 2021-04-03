using System;
using Xunit;
using System.Linq;

namespace key_short_calc.test
{
    public class UnitTestXiaoHe
    {
        private ShortCalaculator calculator= new ShortCalaculator(new XiaoHeEncoder());

        [Fact]
        public void TestNotConvert()
        {
            var actual = new string(calculator.Calc("嘉然").ToArray());
            Assert.True(actual.StartsWith("JR") && actual.Length == 26);
        }

        [Fact]
        public void TestConvert()
        {
            var actual = new string(calculator.Calc("支持真情实感").ToArray());
            Assert.True(actual.StartsWith("VIQUG") && actual.Length == 26);
        }
    }
}
