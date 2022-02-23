using Microsoft.AspNetCore.Mvc.Testing;
using Prova.Integration.Configuration;
using System;
using System.Net.Http;
using Xunit;

namespace Prova.Integration.Test.Fixtures
{
    [CollectionDefinition(nameof(IntegrationApiTestsFixtureCollection))]
    public class IntegrationApiTestsFixtureCollection : ICollectionFixture<IntegrationTestApiFixture> { }

    public class IntegrationTestApiFixture : IDisposable
    {
        public HttpClient Client;

        public IntegrationTestApiFixture()
        {
            var clientOptions = new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = true,
                BaseAddress = new Uri("http://localhost"),
                HandleCookies = true,
                MaxAutomaticRedirections = 7
            };

            var factory = new ApiProvaFactory();
            Client = factory.CreateClient(clientOptions);
        }

        public void Dispose()
        {
            Client.Dispose();
        }
    }
}
