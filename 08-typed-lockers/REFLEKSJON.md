# Refleksjon — Typed Lockers

## Plan før koding

- 
lag to nye objekter av klassen Locker<T>
en hvor T er string
og en hvor T er int

gi dem verdiene "Beacon", 42.
Les verdier
Endre til "Relay", 99 og les igjen

prøv og erstatte Locker<int> med en string og se feilmelding

## Testlogg

| Objekt | Før Replace | Etter Replace |
|---|---|---|
| name | Beacon | Relay |
| id | 42 | 99 |

## Forklaring

Hva er forskjellen mellom typeargumentet int og konstruktørargumentet 42?

Mitt svar:
typeargumentet forteller objektet at T er en integer
konstruktørargumentet 42 forteller objektet at start-verdien til _content for objektet skal være 42

## Hva endret jeg, og hvorfor?

jeg lagde to objekter av klassen Locker<T>

en med string og en annen med int

jeg leste, og endret verdiene til de to objektene
og testet hva som skjer når man prøver og bruke feil type etter at objektet er laget.

## Hva trenger jeg mer øving på?
føler meg komfortabel med generiske typer