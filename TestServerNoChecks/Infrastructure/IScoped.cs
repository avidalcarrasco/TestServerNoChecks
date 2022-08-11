namespace TestServerNoChecks.Infrastructure
{
    public interface IScoped
    {
        IEnumerable<WeatherForecast> Get();
    }
}
