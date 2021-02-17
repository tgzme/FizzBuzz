using FizzBuzz.Controllers;
using FizzBuzz.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace FizzBuzz.UnitTests
{
    [TestClass]
    public class GenericTest
    {
        private readonly Mock<IFizzBuzzer> _mockFizzBuzzer;
        private FizzBuzzController _target;

        public GenericTest()
        {
            _mockFizzBuzzer = new Mock<IFizzBuzzer>();
            _target = new FizzBuzzController(_mockFizzBuzzer.Object);
        }

        [TestMethod]
        public void FizzBuzzIt_ShouldReturnKenThompson_Always()
        {
            const string expectedVal = "fizzBuzzed";

            _mockFizzBuzzer.Setup(x => x.FizzBuzzIt(It.IsAny<IEnumerable<string>>()))
                .Returns(expectedVal);

            var ret = _target.Get(new List<string> { "kenthompson" });

            Assert.AreEqual(expectedVal, ret);
            
            _mockFizzBuzzer.Verify();
                
        }
    }
}
