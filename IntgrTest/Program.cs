using MonoBankApi.Implements;

//Public data tests
var apiClient = new MonoPublic(
    new MonoApiContext(new HttpClient
{
    BaseAddress = new Uri("https://api.monobank.ua")
}));

TestCurrencyInfo(apiClient);

static void TestCurrencyInfo(MonoPublic client)
{
    var data = client.ReturnCurrencyInfoAsync().Result ;

    foreach (var item in data)
    {
        Console.WriteLine("codeA: " + item.CurrencyCodeA);
        Console.WriteLine("codeB: " + item.CurrencyCodeB);
        Console.WriteLine("date: " + DateTimeOffset.FromUnixTimeSeconds(item.Timestamp));
        Console.WriteLine("rateSell: " + item.RateSell);
        Console.WriteLine("rateBuy: " + item.RateBuy);
        Console.WriteLine("rateCross: " + item.RateCross);
        Console.WriteLine("---------------------------------");
    }
}

// Private data tests

// var httpClient = new HttpClient
// {
//     BaseAddress = new Uri("https://api.monobank.ua")
// };
//httpClient.DefaultRequestHeaders.Add("X-Token", "you-token-here");
// var apiClient = new MonoPersonal(
//     new MonoApiContext(httpClient)
// );

//TestWebhookStatus(apiClient);
//TestClientInfo(apiClient);
//TestStatement(apiClient);


// static void TestWebhookStatus(MonoBank client)
// {
//     var data = client.PersonalService.SetWebHookAsync(webhookUrl).Result;

//     Console.WriteLine("status: " + data.Status);
// }

// static void TestClientInfo(MonoPersonal client)
// {
//     var data = client.ReturnClientInfoAsync().Result;

//     Console.WriteLine($"Name: {data.Name}");
//     Console.WriteLine($"ClientId: {data.ClientId}");
//     Console.WriteLine($"WebhookUrl: {data.WebhookUrl}");
//     Console.WriteLine($"Permissions: {data.Permissions}");

//     foreach (var item in data.Accounts)
//     {
//         Console.WriteLine($"    Id: {item.Id}");
//         Console.WriteLine($"    SendId: {item.SendId}");
//         Console.WriteLine($"    Balance: {item.Balance}");
//         Console.WriteLine($"    CreditLimit: {item.CreditLimit}");
//         Console.WriteLine($"    CurrencyCode: {item.CurrencyCode}");
//         Console.WriteLine($"    CashbackType: {item.CashbackType}");

//         foreach (var maskedPan in item.MaskedPan)
//         {
//             Console.WriteLine($"          MaskedPan: {maskedPan}");
//         }
//         Console.WriteLine($"    ---------------------------------");
//     }
//     Console.WriteLine("\nJars:");
//     foreach (var item in data.Jars)
//     {
//         Console.WriteLine($"    Id: {item.Id}");
//         Console.WriteLine($"    SendId: {item.SendId}");
//         Console.WriteLine($"    Title: {item.Title}");
//         Console.WriteLine($"    Description: {item.Description}");
//         Console.WriteLine($"    CurrencyCode: {item.CurrencyCode}");
//         Console.WriteLine($"    Balance: {item.Balance}");
//         Console.WriteLine($"    Goal: {item.Goal}");
//         Console.WriteLine($"    ---------------------------------");
//     }
// }

// static void TestStatement(MonoPersonal client)
// {
//     var data = client.ReturnStatementAsync(new DateTime(2022, 06, 20), DateTime.Now, acc: "acc-id-here").Result;

//     Console.WriteLine("----------// Statements //-------------------");

//     foreach (var item in data)
//     {
//         Console.WriteLine($"Id: {item.Id}");
//         Console.WriteLine($"Time: {DateTimeOffset.FromUnixTimeSeconds(item.Timestamp)}");
//         Console.WriteLine($"Description: {item.Description}");
//         Console.WriteLine($"Mcc: {item.Mcc}");
//         Console.WriteLine($"OriginalMcc: {item.OriginalMcc}");
//         Console.WriteLine($"Hold: {item.Hold}");
//         Console.WriteLine($"Amount: {item.Amount}");
//         Console.WriteLine($"OperationAmount: {item.OperationAmount}");
//         Console.WriteLine($"CurrencyCode: {item.CurrencyCode}");
//         Console.WriteLine($"CommissionRate: {item.CommissionRate}");
//         Console.WriteLine($"CashbackAmount: {item.CashbackAmount}");
//         Console.WriteLine($"Balance: {item.Balance}");
//         Console.WriteLine($"Comment: {item.Comment}");
//         Console.WriteLine($"ReceiptId: {item.ReceiptId}");
//         Console.WriteLine($"InvoiceId: {item.InvoiceId}");
//         Console.WriteLine($"CounterEdrpou: {item.CounterEdrpou}");
//         Console.WriteLine($"CounterIban: {item.CounterIban}");
//         Console.WriteLine("---------------------------------");
//     }
// }
