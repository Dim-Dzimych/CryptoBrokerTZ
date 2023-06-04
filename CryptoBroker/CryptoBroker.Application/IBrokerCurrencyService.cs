namespace CryptoBroker.Application;

public interface IBrokerCurrencyService
{
    Task<decimal> GetCurrency(string currencies);
}