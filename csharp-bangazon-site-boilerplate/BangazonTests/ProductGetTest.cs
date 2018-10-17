using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace BangazonTests
{
    public class ProductGetTest : IClassFixture<WebApplicationFactory<Bangazon.Startup>>
    {
        private readonly WebApplicationFactory<Bangazon.Startup> _factory;

        public ProductGetTest(WebApplicationFactory<Bangazon.Startup> factory)
        {
            _factory = factory;
        }
        [Theory]
        [InlineData("/")]
        [InlineData("/Home")]
        [InlineData("/Home/Products")]

        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.Equal("text/html; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }
    }
}
