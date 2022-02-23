using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;
using Prova.Application.Services;

namespace Prova.Integration.Configuration
{
    internal class ApiProvaFactory : WebApplicationFactory<Program>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddMediatR(typeof(PasswordService));
            });

            builder.UseEnvironment("Testing");
        }
    }
}
