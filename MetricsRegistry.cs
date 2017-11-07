using App.Metrics;
using App.Metrics.Counter;

namespace netapp.Metrics
{
    public static class MetricsRegistry
    {
        public static CounterOptions WeatherForecasts => new CounterOptions
        {
            Name = "WeatherForecasts",
            MeasurementUnit = Unit.Calls
        };
    }

}
