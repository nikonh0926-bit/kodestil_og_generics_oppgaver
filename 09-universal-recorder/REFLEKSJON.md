# Refleksjon — Universal Recorder

## Plan før koding

- 
gjør Recorder.cs til generisk, så den kan bruke forskjellige datatyper

## Testlogg

| Tilfelle | Forventning |
|---|---|
| Ny Recorder<int> | Count 0, Contains(7) false |
| Legg til 7 to ganger | Count 2, Contains(7) true |
| Clear | Count 0, Contains(7) false |
| Tekstbeholder med "Orbit" | Contains("Orbit") true, Contains("orbit") false |
| To beholdere | Endring i én påvirker ikke den andre |

## Forklaring

Hvorfor er det feil å erstatte absolutt alle typer i klassen med T?

Mitt svar:

Fordi vi vil at noen felt skal være spesifikke datatyper.
For eksempel Count, vi vil at den skal være et tall. Så den er fortsatt int.

## Hva endret jeg, og hvorfor?

Jeg endret klassen slik at de typene som ikke må være spesifikke blir generiske

typen til Count ble ikke endret. Fordi jeg vil at den skal være en int.

Når jeg lager et nytt objekt av Recorder<int>. Blir alle typene T i klassen bhandlet som en int.

## Hva trenger jeg mer øving på?
føler meg komfortabel med generiske typer