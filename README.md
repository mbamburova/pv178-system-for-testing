# pv178-system-for-testing

> V ASP.NET MVC implementujte systém pro správu testových otázek, testů a následné zkoušení studentů.

* __Klíčové entity jsou následující:__

  * __Otázka__ je tvořena textem otázky, typem otázky (1 správná odpověď nebo 0-n správných odpovědí), definicí odpovědí, počtem bodů za správnou odpověď a vysvětlením, které se může zobrazit při prohlížení vyhodnocení testu.
  
  * Otázky jsou seskupeny do __tematických okruhů__. Tematické okruhy jsou uspořádány __do hierarchie__. Otázka je vždy zahrnuta jen v jednom tematickém okruhu.
 
  * __Šablona testu__ popisuje základní parametry testu: název testu, čas na vypracování, která skupina studentů může v definovaném časovém intervalu přistupovat k testu, který je tvořen náhodným výběrem určeného počtu testových otázek z určených tematických okruhů
 
  * __Skupina studentů__ seskupuje studenty, aby se jednodušeji vyučujícímu řešila oprávnění pro jednotlivé testy. Student je do skupiny přiřazen na základě znalosti registračního kódu, který mu předá vyučující. Registrace do skupiny probíhá buď při registraci studenta do systému, nebo dodatečně pro již registrované studenty.
 
  * __Student__ se registruje do systému, přičemž uvádí základní osobní údaje. Po přihlášení vidí seznam testů, které má přístupné a může test otevřít a začít vyplňovat.
  
  * __Vyučující__ má administrační rozhraní, které mu umožňuje spravovat tematické okruhy, otázky, šablony testů, skupiny studentů a seznam registrovaných studentů. Podstatné je, že vyučující může efektivně včetně grafického zobrazení procházet výsledky testů svých studentů.
