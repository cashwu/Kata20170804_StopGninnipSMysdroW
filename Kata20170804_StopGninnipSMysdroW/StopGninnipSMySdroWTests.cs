using System;
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
            return sentence;
        }
    }
}
