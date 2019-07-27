using ISO.Library.DTO;
using ISO.Library.Services;
using ISO.Library.Services.Implements;

namespace MonoBankApi.Helper
{
    public static class Iso4217Codes
    {
        static readonly ICurrencyService currencyService;

        static Iso4217Codes()
            => currencyService = new CurrencyService();

        private static Currency Currency(string code)
            => currencyService.ReturnCurrencyAsync(code).Result;

        public static string GetSymbolByCode(int code)
            => Currency(code.ToString()).Symbol;

        public static string GetNameByCode(int code)
            => Currency(code.ToString()).Name;
    }
}
