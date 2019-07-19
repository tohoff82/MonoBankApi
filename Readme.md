## Библиотека для работы с API МоноБанк
Для вызова методов API создайте клиент ```Monobank```  и воспользуйтесь нужным сервисом.
```
var mono = new MonoBank("token");
var wh = await mono.PersonalService.SetWebhookAsync("webhookUrl");  // wh.status = ok;
var data = await mono.PersonalService.ReturnStatement(new DateTime(2019, 06, 01), DateTime.Now, acc: "zCmoEyjv-xw4onV20NqzaA").Result;    
  ```
Конструктивная критика приветствуется.

Если вдруг проявите дикое желание отблагодарить, вот вам номер карты:
💰 5375 4141 0039 1514

Для ленивых <code> <b>--></b> https://send.monobank.com.ua/NNG8cy25 "</code>
