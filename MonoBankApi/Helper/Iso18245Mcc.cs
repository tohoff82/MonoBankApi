using ISO.Library.DTO;
using ISO.Library.Services;
using ISO.Library.Services.Implements;

namespace MonoBankApi.Helper
{
    public static class Iso18245Mcc
    {
        static readonly IMccService mccService;

        static Iso18245Mcc()
            => mccService = new MccService();

        private static MerchantCategory MerchantCategory(string code)
            => mccService.ReturnCategoryAsync(code).Result;

        public static string GetCategoryNameByCode(string code)
            => MerchantCategory(code).UsdaDescription;
    }
}
