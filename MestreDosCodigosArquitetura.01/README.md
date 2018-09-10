# Exercício 1

## Problema

Criar uma aplicação que utilize Orientação a Objetos, demonstrando no código o porque da escolha de pelo menos 3 design patterns, e onde foi aplicado os principios SOLID na aplicação;

## Proposta

Para atender o a especificação foi proposto o seguinte problema:

* Dado que eu seja um cliente de uma instutição bancária
* Gostaria de realizar uma proposta de empréstimo
* Essa proposta deve ser analisada pelo analista responsável
* Após a análise devo receber resultado da proposta

Foram escolhidos alguns padrões:

* Singleton<sup>[1][Singleton]</sup> (**Criacional**)
* Decorator<sup>[2][Decorator]</sup> (**Estrutural**)
* Strategy<sup>[3][Strategy]</sup> (**Comportamental**)
* Chain of Responsibility<sup>[4][ChainOfResponsibility]</sup> (**Comportamental**)

Além disso foram seguidos os 5 píncipios do SOLID<sup>[5][SOLID]</sup> solicitados.

## Execução

Para executar é necessário ter .NET Core 2.1 SDK<sup>[6][.NET]</sup> e executar os seguintes comandos: 

```powershell
dotnet restore
dotnet run
```

[ChainOfResponsibility]: http://www.dofactory.com/net/chain-of-responsibility-design-pattern
[Decorator]: http://www.dofactory.com/net/decorator-design-pattern
[Singleton]: http://www.dofactory.com/net/singleton-design-pattern
[Strategy]: https://www.dofactory.com/net/strategy-design-pattern
[SOLID]: https://en.wikipedia.org/wiki/SOLID
[.NET]: https://www.microsoft.com/net/download
