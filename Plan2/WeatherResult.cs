using System.Collections.Generic;

namespace Planner.Metar
{
    class WeatherResult
    {
        public double results { get; set; }
        public List<Datum> data { get; set; }
    }
    public class Barometer
    {
        public double hg { get; set; }
        public double hpa { get; set; }
        public double kpa { get; set; }
        public double mb { get; set; }
    }

    public class Ceiling
    {
        public double base_feet_agl { get; set; }
        public double base_meters_agl { get; set; }
        public string code { get; set; }
        public double feet { get; set; }
        public double meters { get; set; }
        public string text { get; set; }
    }

    public class Cloud
    {
        public double base_feet_agl { get; set; }
        public double base_meters_agl { get; set; }
        public string code { get; set; }
        public double feet { get; set; }
        public double meters { get; set; }
        public string text { get; set; }
    }

    public class Datum
    {
        public Barometer barometer { get; set; }
        public Ceiling ceiling { get; set; }
        public List<Cloud> clouds { get; set; }
        public Dewpodouble dewpodouble { get; set; }
        public Elevation elevation { get; set; }
        public string flight_category { get; set; }
        public Humidity humidity { get; set; }
        public string icao { get; set; }
        public string observed { get; set; }
        public string raw_text { get; set; }
        public Station station { get; set; }
        public Temperature temperature { get; set; }
        public Visibility visibility { get; set; }
        public Wind wind { get; set; }
    }

    public class Dewpodouble
    {
        public double celsius { get; set; }
        public double fahrenheit { get; set; }
    }

    public class Elevation
    {
        public double feet { get; set; }
        public double meters { get; set; }
    }

    public class Geometry
    {
        public List<double> coordinates { get; set; }
        public string type { get; set; }
    }

    public class Humidity
    {
        public double percent { get; set; }
    }

    public class Root
    {
        public List<Datum> data { get; set; }
        public double results { get; set; }
    }

    public class Station
    {
        public Geometry geometry { get; set; }
        public string location { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Temperature
    {
        public double celsius { get; set; }
        public double fahrenheit { get; set; }
    }

    public class Visibility
    {
        public string meters { get; set; }
        public double meters_float { get; set; }
        public string miles { get; set; }
        public double miles_float { get; set; }
    }

    public class Wind
    {
        public double degrees { get; set; }
        public double speed_kph { get; set; }
        public double speed_kts { get; set; }
        public double speed_mph { get; set; }
        public double speed_mps { get; set; }
    }
}