using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;
using TestServerNoChecks;

namespace TestProject
{
    public class InjectionTest
    {
        [Fact]
        public async Task TestServer_InjectWrongDependencyScope_ThrowException()
        {
            var host = Host.CreateDefaultBuilder(Array.Empty<string>())
                          .ConfigureWebHostDefaults(b =>
                          {
                              b.UseTestServer();
                              b.UseStartup<Startup>();
                          })
                          .Build();

            await host.StartAsync();

            var server = host.GetTestServer();
            HttpResponseMessage response = await server.CreateClient().GetAsync("/weatherforecast");

            var json = await response.Content.ReadAsStringAsync();
            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);

            await host.StopAsync();
        }
    }
}