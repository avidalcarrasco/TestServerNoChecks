using TestServerNoChecks.Infrastructure;

namespace TestServerNoChecks
{
    public class Startup
    {
        public virtual void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //services.AddTransient<ITransient, Transient>();
            //services.AddSingleton<ISingleton, SingletonInjectingTransient>();

            services.AddScoped<IScoped, Scoped>();
            services.AddSingleton<ISingleton, SingletonInjectingScoped>();
        }

        public virtual void Configure(IApplicationBuilder app)
        {
            app.UseRouting();

            app.UseEndpoints(ep => ep.MapControllers());
        }

    }
}
