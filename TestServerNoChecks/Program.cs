using TestServerNoChecks;
namespace TestServerInjection
{
    public class Program
    {
        public static Task Main(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                           .ConfigureWebHostDefaults(b => b.UseStartup<Startup>())
                           .Build()
                           .RunAsync();

            //return new WebHostBuilder().UseKestrel().UseStartup<Startup>().Build().RunAsync();
        }
    }
}