using FluentAssertions;
using PlatformBuilder.Abstractions.Services;
using PlatformBuilder.Core.Services;
using Xunit;

namespace PlatformBuilder.UnitTests.Services
{
    public class PalindromeServiceTest
    {
        private readonly IPalindromeService _service;

        public PalindromeServiceTest()
        {
            _service = new PalindromeService();
        }

        [Theory]
        [InlineData("Deleveled")]
        [InlineData("ararA")]
        [InlineData("0123456789876543210")]
        public void IsPalindrome(string value)
        {
            var result = _service.IsPalindrome(value);

            result.Should().Be(true);
        }

        [Theory]
        [InlineData("Delevelet")]
        [InlineData("arar")]
        public void IsNotPalindrome(string value)
        {
            var result = _service.IsPalindrome(value);

            result.Should().Be(false);
        }
    }
}
