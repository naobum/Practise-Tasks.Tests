using NUnit.Framework;
using Practise_Tasks.Services;

namespace Practise_Tasks.Tests.Task1_Tests.Task2_Tests
{
    [TestFixture]
    class ValidatorTests
    {
        private ReverseInputValidate _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new ReverseInputValidate();
        }

        [Test]
        public void WHEN_empty_string_THEN_false()
        {
            bool result = _validator.IsValid(String.Empty);
            Assert.That(result, Is.False);
        }

        [TestCase("abC")]
        [TestCase("ab1")]
        [TestCase("Ьдв")]
        public void WHEN_string_with_wrong_chars_THEN_false(string input)
        {
            bool result = _validator.IsValid(input);
            Assert.That(result, Is.False);
        }

        [TestCase("abC", "C")]
        [TestCase("ab1", "1")]
        [TestCase("Ьдвer1", "Ьдв1")]
        public void WHEN_string_with_wrong_chars_THEN_returns_wrong_chars(
            string input,
            string expected)
        {
            string result = _validator.GetInvalidChars(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("abc")]
        [TestCase("abced")]
        [TestCase("zxc")]
        public void WHEN_correct_string_THEN_true(string input)
        {
            bool result = _validator.IsValid(input);
            Assert.That(result, Is.True);
        }

    }
}
