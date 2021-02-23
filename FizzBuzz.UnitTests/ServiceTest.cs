using FizzBuzz.Controllers;
using FizzBuzz.DomainModels.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace FizzBuzz.UnitTests
{
    [TestClass]
    public class ServiceTest
    {        
        private Mock<IDivideFizzBuzzerService> _mockDivideFizzBuzzerService;
        private Mock<IAddFizzBuzzerService> _mockAddFizzBuzzerService;
        private FizzBuzzController _target;

        [TestInitialize]
        public void Initialize()
        {
            _mockDivideFizzBuzzerService = new Mock<IDivideFizzBuzzerService>();
            _mockAddFizzBuzzerService = new Mock<IAddFizzBuzzerService>();
            _target = new FizzBuzzController(_mockDivideFizzBuzzerService.Object, _mockAddFizzBuzzerService.Object);
        }

        [TestMethod]
        public void FizzBuzzItDivide_ShouldNotReturnFizzBuzzWhenNot3Or5()
        {
            const string expectedVal = @"Divided 11 by 3\r\n";

            _mockDivideFizzBuzzerService.Setup(x => x.FizzBuzzIt(It.IsAny<IEnumerable<string>>()))
                .Returns(expectedVal);

            var ret = _target.Divide(new List<string> { "11" });

            Assert.AreNotEqual("Fizz-Buzz", ret);

            _mockAddFizzBuzzerService.Verify();

        }

        [TestMethod]
        public void FizzBuzzItDivide_ShouldReturnFizzBuzzWhen3Or5()
        {
            const string expectedVal = "Fizz Buzz";

            _mockDivideFizzBuzzerService.Setup(x => x.FizzBuzzIt(It.IsAny<IEnumerable<string>>()))
                .Returns(expectedVal);

            var ret = _target.Divide(new List<string> { "3", "5" });

            Assert.AreEqual(expectedVal, ret);

            _mockAddFizzBuzzerService.Verify();

        }

        [TestMethod]
        public void FizzBuzzItDivide_ShouldReturnFizzWhenDivisibleBy3()
        {
            const string expectedVal = "Fizz";

            _mockDivideFizzBuzzerService.Setup(x => x.FizzBuzzIt(It.IsAny<IEnumerable<string>>()))
                .Returns(expectedVal);

            var ret = _target.Divide(new List<string> { "6"});

            Assert.AreEqual(expectedVal, ret);

            _mockAddFizzBuzzerService.Verify();

        }

        [TestMethod]
        public void FizzBuzzItDivide_ShouldReturnBuzzWhenDivisibleBy5()
        {
            const string expectedVal = "Buzz";

            _mockDivideFizzBuzzerService.Setup(x => x.FizzBuzzIt(It.IsAny<IEnumerable<string>>()))
                .Returns(expectedVal);

            var ret = _target.Divide(new List<string> { "10" });

            Assert.AreEqual(expectedVal, ret);

            _mockAddFizzBuzzerService.Verify();

        }

        [TestMethod]
        public void FizzBuzzItAdd_ShouldNotReturnFizzDashBuzzWhenOdd()
        {
            const string expectedVal = "The sum of 7 + 0 is odd";

            _mockAddFizzBuzzerService.Setup(x => x.FizzBuzzIt(It.IsAny<IEnumerable<string>>()))
                .Returns(expectedVal);

            var ret = _target.Add(new List<string> { "7", "0" });

            Assert.AreNotEqual("Fizz-Buzz", ret);

            _mockAddFizzBuzzerService.Verify();

        }

        [TestMethod]
        public void FizzBuzzItAdd_ShouldReturnFizzDashBuzzWhenEven()
        {
            const string expectedVal = "Fizz-Buzz";

            _mockAddFizzBuzzerService.Setup(x => x.FizzBuzzIt(It.IsAny<IEnumerable<string>>()))
                .Returns(expectedVal);

            var ret = _target.Add(new List<string> { "6", "0" });

            Assert.AreEqual(expectedVal, ret);

            _mockAddFizzBuzzerService.Verify();

        }

        [TestMethod]
        public void FizzBuzzItAdd_ShouldReturnSumTextWhenOdd()
        {
            const string expectedVal = "The sum of 1+0 is odd" ;

            _mockAddFizzBuzzerService.Setup(x => x.FizzBuzzIt(It.IsAny<IEnumerable<string>>()))
                .Returns(expectedVal);

            var ret = _target.Add(new List<string> { "1", "0" });

            Assert.AreEqual(expectedVal, ret);

            _mockAddFizzBuzzerService.Verify();

        }
    }
}
