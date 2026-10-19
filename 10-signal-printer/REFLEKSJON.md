# Refleksjon — Signal Printer

## Plan før koding

- 

## Testlogg

| Inndata | Forventet utskrift |
|---|---|
| "SOS", "ACK" | SOS og ACK på hver sin linje |
| 1, 2, 3 | 1, 2 og 3 på hver sin linje |
| emptyList<int> | Ingen linjer fra metoden |

## Forklaring

Hvor er T deklarert, og hvordan skiller dette seg fra Recorder<T>?

Mitt svar:

T blir deklarert i metoden. Datatypen blir bestemt ved den individuelle kallet av metoden

ved Recorder<T> ble T deklarert ved skapelsen av objektet av klassen.

## Hva endret jeg, og hvorfor?

jeg endret navn på PrintStrings() til PrintList() og endret argumentet til PrintList<T>(List<T> items)

også endret jeg foreach løkken til (T item in items){}

T blir deklarert ved kallet av metoden. Så hvis input listen er av typen List<string>. Vil alle T i metoden bli behandlet som en string

## Hva trenger jeg mer øving på?
føler meg komfortabel med generiske metoder