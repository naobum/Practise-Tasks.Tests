using NUnit.Framework;
using Practise_Tasks.Services;
using System.Runtime.CompilerServices;

namespace Practise_Tasks.Tests.Task4_Tests
{
    [TestFixture]
    class VowelSpanTests
    {
        private VowelSpan _span;

        [SetUp]
        public void Setup()
        {
            _span = new VowelSpan();
        }
        [TestCase ("zxcvbnmlk")]
        [TestCase ("rwthkl")]
        [TestCase ("wsd")]
        public void WHEN_no_vowels_THEN_empty_string(string input)
        {
            string result = _span.FindSubset(input);
            Assert.That(result, Is.EqualTo(String.Empty));
        }
        [TestCase("aa", "aa")]
        [TestCase("cbafed", "afe")]
        [TestCase("edcbaabcde", "edcbaabcde")]
        [TestCase("bac", "a")]
        public void WHEN_string_with_vowels_THEN_max_vowel_span(
            string input,
            string expected
            )
        {
            string result = _span.FindSubset(input);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
