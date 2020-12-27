using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HitClients.Api.Types.Trading
{
    public class Order
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("clientOrderId")]
        public string ClientOrderId { get; set; }
        
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        
        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
        
        [JsonProperty("type")]
        public string Type { get; set; }
        
        [JsonProperty("timeInForce")]
        public string TimeInForce { get; set; }
        
        [JsonProperty("quantity")]
        public decimal Quantity { get; set; }
        
        [JsonProperty("price")]
        public decimal  Price { get; set; }
        
        [JsonProperty("cumQuantity")]
        public decimal CumQuantity { get; set; }
        
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
        
        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
        
        [JsonProperty("stopPrice")]
        public decimal StopPrice { get; set; }

        public override string ToString()
        {
            return $"{Symbol}: {Price}/{Quantity}";
        }
    }
}
