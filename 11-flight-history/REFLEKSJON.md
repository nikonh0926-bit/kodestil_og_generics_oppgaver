# Refleksjon — Flight History

## Plan før koding

- 

## Testlogg

| Handling | Forventning |
|---|---|
| Ny historikk, GetSnapshot | Tom liste |
| Add("Launch"), Add("Orbit") | Count 2; kopi inneholder Launch, Orbit |
| Fjern alle elementer fra kopien | Historikken har fortsatt Count 2 |
| Hent ny kopi, legg til "Landing" i historikken | Kopien har Count 2; historikken har Count 3 |
| Clear på historikken | Count 0; tidligere kopi har fortsatt Count 2 |

## Forklaring

Hva vil fremdeles være delt dersom T senere er en klasse med endringsbare egenskaper?

Mitt svar:

ettersom GetSnapshot() returnerer en shallow copy
Derfor hvis T blir en klasse med egne objekt-elementer.
Hvil disse elementene kunne bli endret fra Snapshot listen
GetSnapshot() ville derfor måtte returnert en deep copy.


## Hva endret jeg, og hvorfor?

Lagt til hente ut Count av objektets liste.
Laget metode Add() for og legge til nye elementer i listen til objektet
Laget metode Clear() for og fjerne alle elementer i listen til objektet
gjort ferdig metode GetSnapshot() for og få en kopi av den nåværende listen.

## Hva trenger jeg mer øving på?
