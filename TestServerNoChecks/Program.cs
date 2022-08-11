using TestServerNoChecks;
namespace TestServerInjection
{
    public class Program
    {
        public static Task Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                           .ConfigureWebHostDefaults(b => b.UseStartup<Startup>())
                           .Build();

            return host.RunAsync();
        }
    }
}