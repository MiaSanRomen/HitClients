using Newtonsoft.Json;

namespace HitClients.Api.Types.Trading
{
    public class Balance
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("available")]
        public decimal Available { get; set; }

        [JsonProperty("reserved")]
        public decimal Reserved { get; set; }

        public override string ToString()
        {
            return $"{Currency} - {Available}/{Reserved}";
        }
    }
}
