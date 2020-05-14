using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SequenciaFibonacci.Test
{
    [TestClass]
    public class FibonacciTest
    {        
        [TestMethod]
        public void ValidFibonacciTest()
        {
            var fibonacci = new Fibonacci();
            var result = fibonacci.NumerosFibonacci();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IsFibonacciTest()
        {
            var fibonacci = new Fibonacci();
            Assert.IsTrue(fibonacci.IsFibonacci(5));
        }

        [TestMethod]
        public void IsNotFibonacciTest()
        {
            var fibonacci = new Fibonacci();
            Assert.IsFalse(fibonacci.IsFibonacci(4));
        }
    }
}
