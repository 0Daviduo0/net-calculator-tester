using net_calculator_tester;
namespace TestProject1
{
    public class Tests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void TestAddizione()
        {
            float result = calculator.Addizione(2.0f, 3.0f);
            Assert.AreEqual(5.0f, result);
        }

        [Test]
        public void TestSottrazione()
        {
            float result = calculator.Sottrazione(5.0f, 3.0f);
            Assert.AreEqual(2.0f, result);
        }

        [Test]
        public void TestMoltiplicazione()
        {
            float result = calculator.Moltiplicazione(2.0f, 3.0f);
            Assert.AreEqual(6.0f, result);
        }

        [Test]
        public void TestDivisione()
        {
            float result = calculator.Divisione(6.0f, 3.0f);
            Assert.AreEqual(2.0f, result);
        }

        [Test]
        public void TestDivisionePerZero()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divisione(6.0f, 0.0f));
        }
    }
}