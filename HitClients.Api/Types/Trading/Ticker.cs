using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitClients.Api.Types.Trading
{
    public class Ticker
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("last")]
        public decimal Last { get; set; }

        [JsonProperty("open")]
        public decimal Open { get; set; }

        public override string ToString()
        {
            return $"{Symbol}: {Last}";
        }


    }
}
