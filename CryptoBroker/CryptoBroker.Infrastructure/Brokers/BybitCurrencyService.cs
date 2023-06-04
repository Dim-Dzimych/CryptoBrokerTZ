using Bybit.Net.Clients;
using Bybit.Net.Objects;
using CryptoBroker.Application;
using CryptoExchange.Net.Authentication;

namespace CryptoBroker.Infrastructure.Brokers;

public class BybitCurrencyService : IBrokerCurrencyService
{
    public BybitCurrencyService()
    {
        //todo: вынести в конфиг wpf приложения сикрет и ключ
        BybitClient.SetDefaultOptions(new BybitClientOptions
        {
            ApiCredentials = new ApiCredentials("BImL7k1Ukydj0vpX58", "kyzR7qqQvFwUWFpS6DGmcwrCf7p7drHsmmck")
        });
    }
    
    public async Task<decimal> GetCurrency(string currencies = "BTCUSDT")
    {
        using var client = new BybitClient();
        var orderBookData = await client.SpotApiV3.ExchangeData.GetOrderBookAsync(currencies);
        var result = orderBookData.Data.Asks.Where(x => x.Quantity > 0).MinBy(x => x.Price)!.Price;

        return result;
    }
}