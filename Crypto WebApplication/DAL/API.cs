using Crypto_WebApplication.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Crypto_WebApplication.DAL
{
    public class API
    {
        private static JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        private static IRestRequest Request()
        {
            RestRequest restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("x-rapidapi-host", "coinranking1.p.rapidapi.com");
            restRequest.AddHeader("x-rapidapi-key", "edd6273ca1msh28e66769e2520c5p180072jsnc5f1deea8849");

            return restRequest;
        }

        internal static Coins GetCoins()
        {
            RestClient restClient = new RestClient("https://coinranking1.p.rapidapi.com/coins");
            IRestResponse restResponse = restClient.Execute(Request());
            Coins coins = JsonSerializer.Deserialize<Coins>(restResponse.Content, options);

            return coins;
        }

        internal static Coin GetCoin(int id)
        {
            RestClient restClient = new RestClient($"https://coinranking1.p.rapidapi.com/coin/{id}");
            IRestResponse restResponse = restClient.Execute(Request());
            Coin coin = JsonSerializer.Deserialize<Coin>(restResponse.Content, options);

            return coin;
        }

        internal static Stats GetStats()
        {
            RestClient restClient = new RestClient("https://coinranking1.p.rapidapi.com/stats");
            IRestResponse restResponse = restClient.Execute(Request());
            Stats stats = JsonSerializer.Deserialize<Stats>(restResponse.Content, options);

            return stats;
        }

        internal static Exchanges GetExchanges()
        {
            RestClient restClient = new RestClient("https://coinranking1.p.rapidapi.com/exchanges");
            IRestResponse restResponse = restClient.Execute(Request());
            Exchanges exchanges = JsonSerializer.Deserialize<Exchanges>(restResponse.Content, options);

            return exchanges;
        }
        internal static Markets GetMarkets()
        {
            RestClient restClient = new RestClient("https://coinranking1.p.rapidapi.com/markets");
            IRestResponse restResponse = restClient.Execute(Request());
            Markets markets = JsonSerializer.Deserialize<Markets>(restResponse.Content, options);

            return markets;
        }

    }
}
