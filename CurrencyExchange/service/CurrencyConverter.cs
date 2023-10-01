namespace CurrencyExchange.service
{
    public interface ICurrencyExchange
    {
        decimal ConvertUahToUsd(decimal uahAmount);
        decimal ConvertUsdToUah(decimal usdAmount);
        decimal ConvertUahToEur(decimal uahAmount);
        decimal ConvertEurToUah(decimal eurAmount);    
    }
}