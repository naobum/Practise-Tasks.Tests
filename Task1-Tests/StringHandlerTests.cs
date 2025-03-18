using NUnit.Framework;
using Practise_Tasks.Services;

namespace Practise_Tasks.Tests.Task1_Tests
{
    [TestFixture]
    class StringHandlerTests
    {
        private StringHandler _stringHandler;

        [SetUp]
        public void Setup()
        {
            _stringHandler = new StringHandler();
        }

        [TestCase("abcdef", "cbafed")]  
        [TestCase("abcd", "badc")]  
        public void WHEN_even_lenght_string_THEN_reverse_halfes(string oldString, string expected)
        {
            string result = _stringHandler.GetNewString(oldString);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("abcde", "edcbaabcde")]
        [TestCase("a", "aa")]
        public void WHEN_odd_lenght_string_THEN_concat_reverse_string_and_old_string(string oldString, string expected)
        {
            string result = _stringHandler.GetNewString(oldString);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
