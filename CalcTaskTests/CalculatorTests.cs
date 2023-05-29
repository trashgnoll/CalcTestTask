using CalcTask;

namespace CalcTaskTests
{
    public class Tests
    {
        [Test]
        public void TestAdditional()
        {
            var calc = new Calculator();
            Assert.That( calc.Additional(-1, 1), Is.EqualTo(0) );
        }
        [Test]
        public void TestSubtraction()
        {
            var calc = new Calculator();
            Assert.That(calc.Subtraction(-1, -1), Is.EqualTo(0));
        }
        [Test]
        public void TestMiltiplication()
        {
            var calc = new Calculator();
            Assert.That(calc.Miltiplication(5, 2), Is.EqualTo(10));
        }
        [Test]
        public void TestDivision()
        {
            var calc = new Calculator();
            Assert.That(calc.Division(10, 5), Is.EqualTo(2));
        }
    }
}