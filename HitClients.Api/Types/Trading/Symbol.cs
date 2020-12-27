using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HitClients.Api.Types.Trading
{
    public class Symbol
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("baseCurrency")]
        public string BaseCurrency { get; set; }
        [JsonProperty("quoteCurrency")]
        public string QuoteCurrency { get; set; }
        [JsonProperty("quantityIncrement")]
        public decimal QuantityIncrement { get; set; }
        [JsonProperty("tickSize")]
        public decimal TickSize { get; set; }
        [JsonProperty("takeLiquidityRate")]
        public decimal TakeLiquidityRate { get; set; }
        [JsonProperty("provideLiquidityRate")]
        public decimal ProvideLiquidityRate { get; set; }
        public decimal Price { get; set; }
        public decimal Change { get; set; }
        public override string ToString()
        {
            return $"{Id}";
        }
    }
}
