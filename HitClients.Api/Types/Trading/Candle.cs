using System;
using Newtonsoft.Json;

namespace HitClients.Api.Types.Trading
{
    public class Candle
    {
        [JsonProperty("open")]
        public decimal Open { get; set; }
        [JsonProperty("close")]
        public decimal Close { get; set; }
        [JsonProperty("min")]
        public decimal Min { get; set; }
        [JsonProperty("max")]
        public decimal Max { get; set; }

        [JsonProperty("volume")]
        public decimal Volume { get; set; }

        //[JsonProperty("volumeQuote")]
        //public decimal VolumeQuote { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        public override string ToString()
        {
            return $"{Timestamp} {Open} {Min} {Max} {Close}";
        }
    }
}
