using MonoBankApi;
using System;

namespace Test
{
    class Program
    {
        public static string webhookUrl = "https://9f414946.ngrok.io/api/cards";
        public static string token = "u6R8M-T5yoxXcg2F-7dSFnCS7u3dAq0N-RSan4zEr54M";

        static void Main(string[] args)
        {

            var apiClient = new MonoBank(token);

            //TestWebhookStatus(apiClient);
            //TestCurrencyInfo(apiClient);
            TestClientInfo(apiClient);
            //TestStatement(apiClient);
        }

        private static void TestWebhookStatus(MonoBank client)
        {
            var data = client.PersonalService.SetWebHookAsync(webhookUrl).Result;

            Console.WriteLine("status: " + data.Status);
        }

        private static void TestCurrencyInfo(MonoBank client)
        {
            var data = client.PublicService.ReturnCurrencyInfoAsync().Result ;

            foreach (var item in data)
            {
                Console.WriteLine("codeA: " + item.CurrencyCodeA);
                Console.WriteLine("codeB: " + item.CurrencyCodeB);
                Console.WriteLine("date: " + DateTimeOffset.FromUnixTimeSeconds(item.Date));
                Console.WriteLine("rateSell: " + item.RateSell);
                Console.WriteLine("rateBuy: " + item.RateBuy);
                Console.WriteLine("rateCross: " + item.RateCross);
                Console.WriteLine("---------------------------------");
            }
        }

        private static void TestClientInfo(MonoBank client)
        {
            var data = client.PersonalService.ReturnClientInfoAsync().Result;

            Console.WriteLine("Name: " + data.Name);
            foreach (var item in data.Accounts)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Balance: " + item.Balance);
                Console.WriteLine("CreditLimit: " + item.CreditLimit);
                Console.WriteLine("CurrencyCode: " + item.CurrencyCode);
                Console.WriteLine("CashbackSymbol: " + item.CurrencySymbol);
                Console.WriteLine("CashbackName: " + item.CurrencyName);
                Console.WriteLine("CashbackType: " + item.CashbackType);
                Console.WriteLine("---------------------------------");
            }
        }

        private static void TestStatement(MonoBank client)
        {
            var data = client.PersonalService.ReturnStatementAsync(new DateTime(2019, 06, 27), DateTime.Now, acc: "Nzx-GPT5IkKvHKvGT0cwcQ").Result;

            Console.WriteLine("----------// Statements //-------------------");

            foreach (var item in data)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Time: " + DateTimeOffset.FromUnixTimeSeconds(item.Time));
                Console.WriteLine("Description: " + item.Description);
                Console.WriteLine("Mcc: " + item.Mcc);
                Console.WriteLine("Hold: " + item.Hold);
                Console.WriteLine("Amount: " + item.Amount);
                Console.WriteLine("OperationAmount: " + item.OperationAmount);
                Console.WriteLine("CurrencyCode: " + item.CurrencyCode);
                Console.WriteLine("CommissionRate: " + item.CommissionRate);
                Console.WriteLine("CashbackAmount: " + item.CashbackAmount);
                Console.WriteLine("Balance: " + item.Balance);
                Console.WriteLine("---------------------------------");
            }
        }
    }
}
