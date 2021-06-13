using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace PlatformBuilder.IntegrationTests.Controllers
{
    public class PalindromeControllerTest : Base.BaseIntegrationTests
    {
        [Theory]
        [InlineData("Deleveled")]
        [InlineData("ararA")]
        [InlineData("0123456789876543210")]
        public async Task IsPalindrome(string value)
        {
            var response = await httpClient.GetAsync($"api/Palindrome?value={value}");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            bool.Parse(await response.Content.ReadAsStringAsync()).Should().Be(true);
        }

        [Theory]
        [InlineData("Delevelet")]
        [InlineData("arar")]
        public async Task IsNotPalindrome(string value)
        {
            var response = await httpClient.GetAsync($"api/Palindrome?value={value}");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            bool.Parse(await response.Content.ReadAsStringAsync()).Should().Be(false);
        }
    }
}
