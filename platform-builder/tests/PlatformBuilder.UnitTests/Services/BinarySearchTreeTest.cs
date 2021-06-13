using FluentAssertions;
using PlatformBuilder.Abstractions.Entities;
using PlatformBuilder.Abstractions.Services;
using PlatformBuilder.Core.Services;
using Xunit;

namespace PlatformBuilder.UnitTests.Services
{
    public class BinarySearchTreeTest
    {
        private readonly IBinarySearchTreeService _service;

        public BinarySearchTreeTest()
        {
            _service = new BinarySearchTreeService();
        }

        [Theory]
        [InlineData(2, "n2")]
        [InlineData(1, "n1")]
        [InlineData(3, "n3")]
        [InlineData(4, "")]
        public void FindWithValue(int value, string expected)
        {
            var root = _service.GetNode();

            var result = _service.FindWithValue(root, value);

            result.Should().Be(expected);
        }
    }
}
