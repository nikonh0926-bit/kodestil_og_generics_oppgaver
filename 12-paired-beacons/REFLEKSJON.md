# Refleksjon — Paired Beacons

## Plan før koding

- 
Lag Pair.cs met generisk klasse Pair<T>.
Tar imot 2 verdier {first, second} get; private set;
Lag PairDisplay.cs med generisk metode - Tar imot Pair<T> og skriver ut first og second på hver sin linje

## Testlogg

| Inndata Pair<T> | resultat |
|---|---|
| "Første" og "andre" | "første" blir skrevet på en linje og så "andre" på neste linje |
| 1 og 2 | 1 blir skrevet på en linje og så 2 på neste linje |
| beacon1 og beacon2 | "beacon 1" blir skrevet på en linje og så "beacon 2" på neste linje |
| nytt par "tredje" og "fjerde" | Første pair<T> er uendret |


## Forklaring

Hvorfor trenger ikke Pair<T> vite hvilke egenskaper Beacon har? Hva gir generics her som to separate klasser ikke gir?

Mitt svar:

I Pair<T> så blir T bestemt ved kallet på metoden. Generics gir mulighet for og lage en metode som kan håndtere flere typer klasser og datatyper

## Hva endret jeg, og hvorfor?

## Hva trenger jeg mer øving på?
føler meg ganske komfortabel med generiske metoder