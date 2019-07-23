using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Diagnostics;
using System.Collections.Generic;
using MonoBankApi.Models.ISO;
using System.Reflection;

namespace MonoBankApi.Helper
{
    public static class Iso4217Codes
    {
        private static List<Currency> Codes { get; set; }
        private const string codesPath = @"..\..\..\Resources\codes.xml";

        public static long LoadingSpent { get; }

        static Iso4217Codes()
        {
            var timer = new Stopwatch();
            timer.Start();

            LoadXml();

            timer.Stop();
            LoadingSpent = timer.ElapsedMilliseconds;
        }

        public static void LoadXml()
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MonoBankApi.codes.xml"))
            {

                var document = XElement.Load(stream);

                Codes = (from node in document.Descendants("CcyNtry")
                         select new Currency
                         {
                             Country = node.XPathSelectElement("CtryNm")?.Value,
                             Symbol = node.XPathSelectElement("Ccy")?.Value,
                             Name = node.XPathSelectElement("CcyNm")?.Value,
                             Code = node.XPathSelectElement("CcyNbr")?.Value
                         }).ToList();
            }
        }

        public static string GetSimbolByCode(int code)
        {
            return Codes.FirstOrDefault(x => x.Code == code.ToString())?.Symbol;
        }

        public static string GetCurrencyNameByCode(int code)
        {
            return Codes.FirstOrDefault(x => x.Code == code.ToString())?.Name;
        }
    }
}
