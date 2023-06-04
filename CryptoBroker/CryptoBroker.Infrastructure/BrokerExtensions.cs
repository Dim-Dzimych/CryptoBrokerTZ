using CryptoBroker.Domain;

namespace CryptoBroker.Infrastructure;

public static class BrokerExtensions
{
    public static string GetBtcUsdtCurrencyPair(this BrokerType type)
    {
        return type switch
        {
            BrokerType.Bybit or BrokerType.Binance => "BTCUSDT",
            BrokerType.Kucoin => "BTC-USDT",
            _ => throw new ArgumentException()
        };
    }
}