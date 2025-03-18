using NUnit.Framework;
using Practise_Tasks.Services.Sortings;

namespace Practise_Tasks.Tests.Task5_Tests
{
    [TestFixture]
    class QuckSortingTests
    {
        private QuickSort _sorter;

        [SetUp]
        public void Setup()
        {
            _sorter = new QuickSort();
        }
        [TestCase("abc", "abc")]
        [TestCase("cba", "abc")]
        [TestCase("cab", "abc")]
        public void WHEN_random_string_THEN_sorted_string(
            string input,
            string expected)
        {
            string result = input;
            _sorter.Sort(ref result);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void WHEN_empty_string_THEN_empty_string()
        {
            string result = String.Empty;
            _sorter.Sort(ref result);
            Assert.That(result, Is.EqualTo(String.Empty));
        }
    }
}
