using System.Collections.Generic;

namespace Planner.TAF
{
    class WeatherResult
    {
        public double results { get; set; }
        public List<Datum> data { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Ceiling
    {
        public double base_feet_agl { get; set; }
        public double base_meters_agl { get; set; }
        public string code { get; set; }
        public double feet { get; set; }
        public double meters { get; set; }
        public string text { get; set; }
    }

    public class Change
    {
        public Indicator indicator { get; set; }
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
        public List<Forecast> forecast { get; set; }
        public string icao { get; set; }
        public string raw_text { get; set; }
        public Station station { get; set; }
        public Timestamp timestamp { get; set; }
    }

    public class Forecast
    {
        public List<Cloud> clouds { get; set; }
        public Timestamp timestamp { get; set; }
        public Visibility visibility { get; set; }
        public Wind wind { get; set; }
        public Change change { get; set; }
        public Ceiling ceiling { get; set; }
    }

    public class Geometry
    {
        public List<double> coordinates { get; set; }
        public string type { get; set; }
    }

    public class Indicator
    {
        public string code { get; set; }
        public string desc { get; set; }
        public string text { get; set; }
    }

    public class Root
    {
        public double results { get; set; }
        public List<Datum> data { get; set; }
    }

    public class Station
    {
        public Geometry geometry { get; set; }
        public string icao { get; set; }
        public string location { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Timestamp
    {
        public string from { get; set; }
        public string to { get; set; }
        public string bulletin { get; set; }
        public string issued { get; set; }
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
