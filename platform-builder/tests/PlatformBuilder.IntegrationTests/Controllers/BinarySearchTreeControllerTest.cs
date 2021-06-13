using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace PlatformBuilder.IntegrationTests.Controllers
{
    public class BinarySearchTreeControllerTest : Base.BaseIntegrationTests
    {
        [Theory]
        [InlineData(2, "n2")]
        [InlineData(1, "n1")]
        [InlineData(3, "n3")]
        [InlineData(4, "")]
        public async Task FindWithValue(int value, string expected)
        {
            var response = await httpClient.GetAsync($"api/BinarySearchTree?value={value}");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            (await response.Content.ReadAsStringAsync()).Should().Be(expected);
        }
    }
}
