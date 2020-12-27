using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HitClients.Api.Types.Trading
{
        public class Trade
        {
            [JsonProperty("id")]
            public string Id { get; set; }
            [JsonProperty("orderId")]
            public long OrderId { get; set; }
            [JsonProperty("symbol")]
            public string Symbol { get; set; }
            [JsonProperty("side")]
            public string Side { get; set; }
            [JsonProperty("quantity")]
            public decimal Quantity { get; set; }
            [JsonProperty("price")]
            public decimal Price { get; set; }
            [JsonProperty("fee")]
            public decimal Fee { get; set; }
            [JsonProperty("timestamp")]
            public DateTime Timestamp { get; set; }
        }
    
    
}
