using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Diagnostics;
using System.Collections.Generic;
using MonoBankApi.Models.ISO;

namespace MonoBankApi.Helper
{
    public static class Iso4217Codes
    {
        private static List<Currency> Codes { get; set; }
        private const string codesPath = @"./Assets/codes.xml";

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
            var document = XElement.Load(codesPath);

            Codes = (from node in document.Descendants("CcyNtry")
                     select new Currency
                     {
                         Country = node.XPathSelectElement("CtryNm")?.Value,
                         Code = node.XPathSelectElement("Ccy")?.Value,
                         Name = node.XPathSelectElement("CcyNm")?.Value,
                         Num = node.XPathSelectElement("CcyNbr")?.Value
                     }).ToList();
        }

        public static string GetCodeByNumber(string number)
        {
            return Codes.FirstOrDefault(x => x.Num == number)?.Code;
        }

        public static string GetCurrencyNameByNumber(string number)
        {
            return Codes.FirstOrDefault(x => x.Num == number)?.Name;
        }
    }
}
