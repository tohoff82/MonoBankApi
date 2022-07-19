## Библиотека для работы с API МоноБанк
Докумментация https://api.monobank.ua/docs/index.html
Для использования установите пакет <code>[Install-Package CryptoPay.Conector -Version 0.0.1](https://www.nuget.org/packages/Mono.Api.Connector/)</code>

Для вызова методов API воспользуйтесь внедрением зависимостей в ваш контейнер.
```
services.AddMonoApi("token"); 


public class ConectorService
{
    private readonly IMonoPersonal _conector;

    public ConectorService(IMonoPersonal conector)
    {
        _conector = conector;
    }
}

...

var result = await _connector.SetWebHookAsync("webhook-url");
```

Конструктивная критика приветствуется.


Если вдруг проявите дикое желание отблагодарить <code> <b>--></b> https://send.monobank.com.ua/NNG8cy25 "</code>
