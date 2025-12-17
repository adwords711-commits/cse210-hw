using System.Runtime.InteropServices.Marshalling;

public class OutdoorGathering : Event
{
    private string _weatherForecast;
    public OutdoorGathering( string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }
    public new string FullDetails()
    {
        string details = base.GetDetails();
        details += $"\nWeather Forecast: {_weatherForecast}";
        return details;
    }
}