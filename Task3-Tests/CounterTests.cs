using NUnit.Framework;
using Practise_Tasks.Services;

namespace Practise_Tasks.Tests.Task3_Tests
{
    [TestFixture]
    class CounterTests
    {
        private CharsCounter _counter;

        [SetUp]
        public void Setup()
        {
            _counter = new CharsCounter();
        }
        [Test]
        public void WHEN_empty_string_THEN_empty_dict()
        {
            Dictionary<char, int> result = _counter.CountItems(String.Empty);
            Assert.That(result, Is.Empty);
        }
        [TestCaseSource(nameof(NotEmptyStringCases))]
        public void WHEN_not_empty_string_THEN_correct_chars_amount(
            string input, 
            Dictionary<char, int> expected)
        {
            Dictionary<char, int> result = _counter.CountItems(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        static object[] NotEmptyStringCases =
        {
            new object[] {"abc", new Dictionary<char, int> { 
                                                             {'a', 1},
                                                             {'b', 1},
                                                             {'c', 1} }
            },
            new object[] {"aabbbcccc", new Dictionary<char, int> { 
                                                             {'a', 2},
                                                             {'b', 3},
                                                             {'c', 4} }
            },
            new object[] {"x", new Dictionary<char, int> { {'x', 1} }
            }
        };
    }
}
