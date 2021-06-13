using Microsoft.AspNetCore.Mvc.Testing;
using PlatformBuilder.WebApi;
using System.Net.Http;

namespace PlatformBuilder.IntegrationTests.Base
{
    public abstract class BaseIntegrationTests
    {
        protected readonly HttpClient httpClient;

        public BaseIntegrationTests()
        {
            httpClient = new WebApplicationFactory<Startup>().CreateClient();
        }
    }
}
