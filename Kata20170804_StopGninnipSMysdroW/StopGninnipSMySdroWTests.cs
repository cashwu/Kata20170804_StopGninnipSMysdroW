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

        [TestMethod]
        public void input_Hey_fellow_warriors_should_return_Hey_wollef_sroirraw()
        {
            AssertSpinWordsShouldBe("Hey wollef sroirraw", "Hey fellow warriors");
        }

        [TestMethod]
        public void input_This_is_a_test_should_return_This_is_a_test()
        {
            AssertSpinWordsShouldBe("This is a test", "This is a test");
        }

        [TestMethod]
        public void input_This_is_another_test_should_return_This_is_rehtona_test()
        {
            AssertSpinWordsShouldBe("This is another test", "This is rehtona test");
        }

        [TestMethod]
        public void input_You_are_tsomla_to_the_last_test()
        {
            AssertSpinWordsShouldBe("You are almost to the last test", "You are tsomla to the last test");
        }

        [TestMethod]
        public void input_Just_kidding_there_is_still_one_more()
        {
            AssertSpinWordsShouldBe("Just gniddik ereht is llits one more", "Just kidding there is still one more");
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
