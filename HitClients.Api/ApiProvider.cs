using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HitClients.Api.Types.Authentication;
using HitClients.Api.Types.Requests;
using HitClients.Api.Types.Trading;
using RestSharp;
using RestSharp.Authenticators;

namespace HitClients.Api
{
    public static class ApiProvider
    {
        private const string Url = "https://api.hitbtc.com";
        private static LoginKey _loginKey;
        public static bool IsLogin;
        public static event EventHandler LoginEvent;


        public static bool Login(LoginKey loginKey)
        {
            _loginKey = loginKey;
            var client = new RestClient(Url);
            client.Authenticator = new HttpBasicAuthenticator(_loginKey.Login, _loginKey.Pass);
            var request = new RestRequest("/api/2/trading/balance", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var result = client.Execute<List<Balance>>(request);
            if (result.IsSuccessful)
            {
                IsLogin = true;
                OnLoginEvent();
                return true;
                
            }
            else
            {
                IsLogin = false;
                return false;
            }
        }

        public static List<Balance> GetBalance()
        {
            if (_loginKey == null) return null;
            var client = new RestClient(Url);
            client.Authenticator = new HttpBasicAuthenticator(_loginKey.Login, _loginKey.Pass);
            var request = new RestRequest("/api/2/trading/balance", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var result = client.Execute<List<Balance>>(request);
            if (result.IsSuccessful)
            {
                return result.Data;
            }
            return null;
        }

        public static List<Symbol> GetSymbols()
        {
            var client = new RestClient(Url);
            var request = new RestRequest("/api/2/public/symbol", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var result = client.Execute<List<Symbol>>(request);
            if (result.IsSuccessful)
            {
                return result.Data;
            }
            return null;
        }

        public static List<Candle> GetCandles(CandleRequest r)
        {
            var client = new RestClient(Url);
            var request = new RestRequest($"/api/2/public/candles/{r.Symbol}", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var result = client.Execute<List<Candle>>(request);
            if (result.IsSuccessful)
            {
                return result.Data;
            }
            return null;
        }

        public static List<Ticker> GetTickers()
        {
            var client = new RestClient(Url);
            var request = new RestRequest("/api/2/public/ticker", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var result = client.Execute<List<Ticker>>(request);
            if (result.IsSuccessful)
            {
                return result.Data;
            }
            return null;
        }

        public static List<Order> GetActiveOrders()
        {
            if (!IsLogin) return null;

            var client = new RestClient(Url);
            client.Authenticator = new HttpBasicAuthenticator(_loginKey.Login, _loginKey.Pass);
            var request = new RestRequest("/api/2/order", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var result = client.Execute<List<Order>>(request);
            if (result.IsSuccessful)
            {
                return result.Data;
            }
            return null;
        }

        public static List<Order> GetOrders()
        {
            if (!IsLogin) return null;

            var client = new RestClient(Url);
            client.Authenticator = new HttpBasicAuthenticator(_loginKey.Login, _loginKey.Pass);
            var request = new RestRequest("/api/2/order", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var result = client.Execute<List<Order>>(request);
            if (result.IsSuccessful)
            {
                return result.Data;
            }
            return null;
        }

        public static List<Trade> GetTradesHistory()
        {
            if (!IsLogin) return null;
            var client = new RestClient(Url);
            client.Authenticator = new HttpBasicAuthenticator(_loginKey.Login, _loginKey.Pass);
            var request = new RestRequest("/api/2/history/trades", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var result = client.Execute<List<Trade>>(request);
            if (result.IsSuccessful)
            {
                return result.Data;
            }
            return null;
        }

        public static Order CreateOrder(Order o)
        {
            if (!IsLogin) return null;
            var client = new RestClient(Url);
            client.Authenticator = new HttpBasicAuthenticator(_loginKey.Login, _loginKey.Pass);
            var request = new RestRequest($"/api/2/order", Method.POST);
            request.RequestFormat = DataFormat.Json;
            var price = o.Price.ToString(CultureInfo.InvariantCulture);
            var quantity = o.Quantity.ToString(CultureInfo.InvariantCulture);
            request.AddParameter("symbol", o.Symbol, ParameterType.GetOrPost);
            request.AddParameter("side", o.Side.ToString(), ParameterType.GetOrPost);
            request.AddParameter("type", o.Type.ToLower(), ParameterType.GetOrPost);
            request.AddParameter("quantity", quantity, ParameterType.GetOrPost);
            request.AddParameter("price", price, ParameterType.GetOrPost);
            var result = client.Execute<Order>(request);
            if (result.IsSuccessful)
            {
                return result.Data;
            }
            return null;
        }

        public static Order CancelOrder(Order o)
        {
            var client = new RestClient(Url);
            client.Authenticator = new HttpBasicAuthenticator(_loginKey.Login, _loginKey.Pass);
            var request = new RestRequest($"/api/2/order/{o.ClientOrderId}", Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            var result = client.Execute<Order>(request);
            if (result.IsSuccessful)
            {
                return result.Data;
            }
            return null;
        }

        private static void OnLoginEvent()
        {
            LoginEvent?.Invoke(null, EventArgs.Empty);
        }
    }
}
