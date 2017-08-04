using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170804_StopGninnipSMysdroW
{
    [TestClass]
    public class StopGninnipSMySdroWTests
    {
        //https://www.codewars.com/kata/stop-gninnips-my-sdrow

        [TestMethod]
        public void input_test_should_return_test()
        {
            AssertSpinWordsShouldBe("test", "test");
        }

        [TestMethod]
        public void input_This_test_should_return_This_test()
        {
            AssertSpinWordsShouldBe("This test", "This test");
        }

        [TestMethod]
        public void input_fellow_should_return_wollef()
        {
            AssertSpinWordsShouldBe("fellow", "wollef");
        }

        private static void AssertSpinWordsShouldBe(string expected, string sentence)
        {
            var kata = new Kata();
            var actual = kata.SpinWords(sentence);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public string SpinWords(string sentence)
        {
            return string.Join(" ",
                sentence.Split(new[] {' '}).Select(a => string.Join("", a.Length >= 5 ? a.Reverse() : a)));
        }
    }
}
