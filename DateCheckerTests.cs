using NUnit.Framework;

namespace DateTimeChecker.Tests
{
    [TestFixture]
    public class DateCheckerTests
    {
        private DateChecker _dateChecker;

        [SetUp]
        public void SetUp()
        {
            _dateChecker = new DateChecker();
        }

        [Test]
        [TestCase(29, 2, 2020, ExpectedResult = true)] // Năm nhuận
        [TestCase(29, 2, 2021, ExpectedResult = false)] // Không phải năm nhuận
        [TestCase(31, 4, 2021, ExpectedResult = false)] // Tháng 4 không có ngày 31
        [TestCase(1, 1, 2021, ExpectedResult = true)] // Ngày hợp lệ
        [TestCase(31, 12, 2021, ExpectedResult = true)] // Ngày hợp lệ
        [TestCase(0, 12, 2021, ExpectedResult = false)] // Ngày không hợp lệ
        [TestCase(31, 0, 2021, ExpectedResult = false)] // Tháng không hợp lệ
        [TestCase(31, 13, 2021, ExpectedResult = false)] // Tháng không hợp lệ
        [TestCase(31, 12, -1, ExpectedResult = false)] // Năm không hợp lệ
        public bool IsValidDateTests(int day, int month, int year)
        {
            return _dateChecker.IsValidDate(day, month, year);
        }
    }
}
