using System;
using System.Globalization;
using System.Linq;
using Humanizer.Localisation;
using Xunit;

namespace Humanizer.Tests.enZA
{
    [UseCulture("en-ZA")]
    public class TimeSpanHumanizeTests
    {
        [Theory]
        [Trait("Translation", "Google")]
        [InlineData(366, "1 year")]
        [InlineData(731, "2 years")]
        [InlineData(1096, "3 years")]
        [InlineData(4018, "11 years")]
        public void Years(int days, string expected)
        {
            Assert.Equal(expected, TimeSpan.FromDays(days).Humanize(maxUnit: Humanizer.Localisation.TimeUnit.Year));
        }

        [Theory]
        [Trait("Translation", "Google")]
        [InlineData(31, "1 month")]
        [InlineData(61, "2 months")]
        [InlineData(92, "3 months")]
        [InlineData(335, "11 months")]
        public void Months(int days, string expected)
        {
            Assert.Equal(expected, TimeSpan.FromDays(days).Humanize(maxUnit: Humanizer.Localisation.TimeUnit.Year));
        }
 
        [Fact]
        public void TwoWeeks()
        {
            Assert.Equal("2 weeks", TimeSpan.FromDays(14).Humanize());
        }

        [Fact]
        public void OneWeek()
        {
            Assert.Equal("1 week", TimeSpan.FromDays(7).Humanize());
        }

        [Fact]
        public void SixDays()
        {
            Assert.Equal("6 days", TimeSpan.FromDays(6).Humanize());
        }

        [Fact]
        public void TwoDays()
        {
            Assert.Equal("2 days", TimeSpan.FromDays(2).Humanize());
        }

        [Fact]
        public void OneDay()
        {
            Assert.Equal("1 day", TimeSpan.FromDays(1).Humanize());
        }

        [Fact]
        public void TwoHours()
        {
            Assert.Equal("2 hours", TimeSpan.FromHours(2).Humanize());
        }

        [Fact]
        public void OneHour()
        {
            Assert.Equal("1 hour", TimeSpan.FromHours(1).Humanize());
        }

        [Fact]
        public void TwoMinutes()
        {
            Assert.Equal("2 minutes", TimeSpan.FromMinutes(2).Humanize());
        }

        [Fact]
        public void OneMinute()
        {
            Assert.Equal("1 minute", TimeSpan.FromMinutes(1).Humanize());
        }

        [Fact]
        public void TwoSeconds()
        {
            Assert.Equal("2 seconds", TimeSpan.FromSeconds(2).Humanize());
        }

        [Fact]
        public void OneSecond()
        {
            Assert.Equal("1 second", TimeSpan.FromSeconds(1).Humanize());
        }

        [Fact]
        public void TwoMilliseconds()
        {
            Assert.Equal("2 milliseconds", TimeSpan.FromMilliseconds(2).Humanize());
        }

        [Fact]
        public void OneMillisecond()
        {
            Assert.Equal("1 millisecond", TimeSpan.FromMilliseconds(1).Humanize());
        }

        [Fact]
        public void NoTime()
        {
            Assert.Equal("0 milliseconds", TimeSpan.Zero.Humanize());
        }

        [Fact]
        public void NoTimeToWords()
        {
            Assert.Equal("no time", TimeSpan.Zero.Humanize(toWords: true));
        }
   }
}
