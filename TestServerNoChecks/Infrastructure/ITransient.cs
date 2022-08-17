namespace TestServerNoChecks.Infrastructure
{
    public interface ITransient
    {
        IEnumerable<WeatherForecast> Get();
    }
}
