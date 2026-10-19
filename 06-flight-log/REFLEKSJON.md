# Refleksjon — Flight Log

## Plan før koding

- 
fullfør instansemetoder Add() og Count() i FlightLog.cs

_entries.Count skal holde telling over antall string i listen. Skal ikke være noen andre tellerfelt

fullfør Clear().

## Testlogg

| Handling | Forventet Count |
|---|---|
| første logg | 0 |
| andre logg | 0 |
| første Add("Launch") | 1 |
| første Add("Orbit") | 2 |
| andre Add("Launch") | 1 |
| andre Add("Orbit") | 2 |
| første Clear() | 0 |
| andre Add("Landing") | 3 |

## Forklaring

Hva kan gå galt hvis både listen og et eget tellerfelt lagrer antallet?


Mitt svar:

de kan bli usynkronisert.

For eksempel. 
hvis man har en egen int logCounter i Program.cs som teller hver gang en ny string blir lagt til i log

og så lagger til en ny log fra en annen fil som ikke oppdaterer logCounter. 
Vill logCounter og _entries.Count() være forskjellig.

## Hva endret jeg, og hvorfor?

jeg la til return _entries.Count i for Count.

jeg gjorde ferdig Add() i klassen

jeg gjorde ferdig Clear() i klassen

## Hva trenger jeg mer øving på?
føler meg veldig komfortabel med instansmetoder og statiske felt