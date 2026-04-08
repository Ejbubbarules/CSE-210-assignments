class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string desc, string date, string time, Address address, string weather)
        : base(title, desc, date, time, address)
    {
        _weather = weather;
    }

    public string GetFullDetails()
    {
        return $"Outdoor Event\n{GetStandardDetails()}\nWeather: {_weather}";
    }
}