## Библиотека для работы с API МоноБанк
Для вызова методов API создайте клиент ```Monobank```  и воспользуйтесь нужным сервисом.
```
var mono = new MonoBank("token");
var wh = await mono.PersonalService.SetWebhookAsync("webhookUrl");  // wh.status = ok;
var data = await mono.PersonalService.ReturnStatementAsync(new DateTime(2019, 06, 01), DateTime.Now, acc: "zCmoEyjv-xw4onV20NqzaA");    
  ```
Конструктивная критика приветствуется.

Если вдруг проявите дикое желание отблагодарить <code> <b>--></b> https://send.monobank.com.ua/NNG8cy25 "</code>
