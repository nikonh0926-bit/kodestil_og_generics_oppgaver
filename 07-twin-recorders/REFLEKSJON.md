# Refleksjon — Twin Recorders

## Plan før koding

- 
fullfør Clear() metoden for NumberRecorder og TextRecorder
kalle på Clear() metoden og lage fler tests i Program.cs
## Testlogg
| Handling | Forventning |
|---|---|
| Legg til "Orbit" / 7 | Begge har Count 1 |
| Søk etter "Orbit" / 7 | Begge gir true |
| Søk etter "Landing" / 9 | Begge gir false |
| Clear på begge | Begge har Count 0 og finner ikke gammel verdi |
| Clear på tom beholder | Count forblir 0 |

## Forklaring

Hva måtte vært forskjellig i reglene for at du ville beholdt to separate klasser?

Mitt svar:
I dette tilfelle, ville jeg bare brukt en generisk klasse, ettersom de behandler verdiene helt identisk.
Hvis hver klasse hadde helt forskjellige funksjoner og blir brukt helt forksjellig fra hverandre

## Hva endret jeg, og hvorfor?
gjorde ferdig metoden Clear() i hver klasse:
_items.Clear();

## Hva trenger jeg mer øving på?
føler meg komfortabel med klasser, og gjenkjenne når man bør bruke generics