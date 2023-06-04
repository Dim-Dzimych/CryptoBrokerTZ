using System.Collections.Concurrent;
using CryptoBroker.Application;
using CryptoBroker.Domain;

namespace CryptoBroker.Infrastructure.Brokers;

public class CurrencyWorker
{
    public ConcurrentDictionary<BrokerType, decimal> Currencies { get; set; } = new();

    public void StartWorker(CancellationTokenSource? cts = null)
    {
        cts ??= new CancellationTokenSource();
        var delay = TimeSpan.FromSeconds(5);

        Task.Run(async () =>
        {
            while (!cts.IsCancellationRequested)
            {
                try
                {
                    await Execute();
                    await Task.Delay(delay);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    await Task.Delay(delay);
                }
            }
        });
    }

    private async Task Execute()
    {
        //todo: need di
        var services = new Dictionary<BrokerType, IBrokerCurrencyService>
        {
            {BrokerType.Binance, new BinanceCurrencyService()},
            {BrokerType.Bybit, new BybitCurrencyService()},
            {BrokerType.Kucoin, new KucoinCurrencyService()}
        };

        await Parallel.ForEachAsync(services, async (service, ct) =>
        {
            if(ct.IsCancellationRequested)
                return;

            var result = await service.Value.GetCurrency(service.Key.GetBtcUsdtCurrencyPair());
            
            Currencies.AddOrUpdate(service.Key, result, (key, oldValue) => result);
        });
    }
}