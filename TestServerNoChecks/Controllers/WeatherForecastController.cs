using Microsoft.AspNetCore.Mvc;
using TestServerNoChecks.Infrastructure;

namespace TestServerNoChecks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ISingleton _singleton;

        public WeatherForecastController(ISingleton singleton) => _singleton = singleton;

        [HttpGet]
        public IEnumerable<WeatherForecast> Get() => _singleton.Get();
    }
}