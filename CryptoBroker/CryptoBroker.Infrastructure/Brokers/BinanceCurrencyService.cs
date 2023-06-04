using Binance.Net.Clients;
using Binance.Net.Objects;
using CryptoBroker.Application;

namespace CryptoBroker.Infrastructure.Brokers;

public class BinanceCurrencyService : IBrokerCurrencyService
{
    public BinanceCurrencyService()
    {
        // //todo: вынести в конфиг wpf приложения сикрет и ключ
        // BinanceClient.SetDefaultOptions(new BinanceClientOptions
        // {
        //     ApiCredentials = new BinanceApiCredentials("APIKEY", "secret")
        // });
        //
        // //todo: вынести в конфиг wpf приложения сикрет и ключ
        // BinanceSocketClient.SetDefaultOptions(new BinanceSocketClientOptions
        // {
        //     ApiCredentials = new BinanceApiCredentials("APIKEY", "SECRET")
        // });
    }
    
    public async Task<decimal> GetCurrency(string currencies = "BTCUSDT")
    {
        using var client = new BinanceClient();
        var result = await client.SpotApi.ExchangeData.GetBookPriceAsync(currencies);

        return result.Data.BestAskPrice;
    }
}