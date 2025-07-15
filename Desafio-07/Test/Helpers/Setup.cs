using Microsoft.AspNetCore.Hosting;

using Dominio.Interfaces;
using Test.Mocks;
using Microsoft.Extensions.DependencyInjection;

namespace Test.Helpers;

public class Setup
{
    public const string PORT = "5001";
    public static TestContext testContext = default!;
    public static WebApplicationFactory<Startup> http = default!;
    public static HttpClient client = default!;

    public static void ClassInit(TestContext testContext)
    {
#pragma warning disable MSTEST0024 // Não armazene TestContext em um membro estático
        Setup.testContext = testContext;
#pragma warning restore MSTEST0024 // Não armazene TestContext em um membro estático
        Setup.http = new WebApplicationFactory<Startup>();

        Setup.http = Setup.http.WithWebHostBuilder(builder =>
        {
            builder.UseSetting("https_port", Setup.PORT).UseEnvironment("Testing");
            
            builder.ConfigureServices(services =>
            {
                services.AddScoped<IAdministradorServico, AdministradorServicoMock>();
            });

        });

        Setup.client = Setup.http.CreateClient();
    }

    public static void ClassCleanup()
    {
        Setup.http.Dispose();
    }
}

public class Startup
{
}

public class WebApplicationFactory<T>
{
    internal WebApplicationFactory<Startup> WithWebHostBuilder(Action<IWebHostBuilder> configure)
    {
        throw new NotImplementedException();
    }

    public HttpClient CreateClient()
    {
        // In a real scenario, this would configure and return an HttpClient for the test server.
        // For now, return a new HttpClient instance.
        return new HttpClient();
    }

    internal void Dispose()
    {
        throw new NotImplementedException();
    }
}