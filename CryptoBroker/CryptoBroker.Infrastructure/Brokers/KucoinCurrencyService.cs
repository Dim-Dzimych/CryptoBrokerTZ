using System.Text;
using CryptoBroker.Application;
using CryptoBroker.Domain;
using Kucoin.Net.Clients;
using Kucoin.Net.Objects;
using Newtonsoft.Json;

namespace CryptoBroker.Infrastructure.Brokers;

public class KucoinCurrencyService : IBrokerCurrencyService, IDisposable
{
    private readonly MemoryStream _apiCredentials;
    
    public KucoinCurrencyService()
    {
        //todo: вынести в конфиг wpf приложения сикрет и ключ
        // var configJson = JsonConvert.SerializeObject(new KucoinOptions("647917f98289d80001e0cbba", "cbd49fca-227a-4dd6-9ecb-13c852d4115f", "121314"));
        // _apiCredentials = new MemoryStream(Encoding.UTF8.GetBytes(configJson));
        //
        // KucoinClient.SetDefaultOptions(new KucoinClientOptions
        // {
        //     ApiCredentials = new KucoinApiCredentials(_apiCredentials)
        // });
    }
    
    public async Task<decimal> GetCurrency(string currencies = "BTC-USDT")
    {
        using var client = new KucoinClient();
        var orderBookData = await client.SpotApi.ExchangeData.GetAggregatedPartialOrderBookAsync(currencies, 20);
        var result = orderBookData.Data.Asks.Where(x => x.Quantity > 0).MinBy(x => x.Price)!.Price;

        return result;
    }

    public void Dispose()
    {
        _apiCredentials.Dispose();
    }
}