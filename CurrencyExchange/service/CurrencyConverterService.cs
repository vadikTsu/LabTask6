namespace CurrencyExchange.service
{
    public class CurrencyConverterService
    {
        private decimal usdToUahRate;
        private decimal eurToUahRate;

        public CurrencyConverterService(decimal usdRate, decimal eurRate)
        {
            usdToUahRate = usdRate;
            eurToUahRate = eurRate;
        }

        public decimal ConvertUahToUsd(decimal uahAmount)
        {
            return uahAmount / usdToUahRate;
        }

        public decimal ConvertUsdToUah(decimal usdAmount)
        {
            return usdAmount * usdToUahRate;
        }

        public decimal ConvertUahToEur(decimal uahAmount)
        {
            return uahAmount / eurToUahRate;
        }

        public decimal ConvertEurToUah(decimal eurAmount)
        {
            return eurAmount * eurToUahRate;
        }
    }
}