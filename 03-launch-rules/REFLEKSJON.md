# Refleksjon — Launch Rules

## Plan før koding

- 
refaktorer metoden CanLaunch() til og returnere svar med en gang et krav ikke er oppfylt.

CanLaunch() 
Hvis mannskapet er lik eller større 3.
Hvis drivstoff er lik eller større 50.
Hvis luken er lukket.
returner sann.
Hvis ikke returner usann.

metoden sjekker alle kriterier uansett om de er sanne eller usanne.
Fører til mange unødvendige checks.

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|---|---|---|
| 3, 50, true | true | true |       Alt i orden
| 2, 50, true | false | false |     Ikke nok mannskap
| 3, 45, true | false | false |     ikke nok drivstoff
| 3, 50, false | false | false |    luken er ikke lukket

## Forklaring

Hvorfor er dette refaktorering og ikke en ny oppskytingsregel?

Fordi metoden fungerer på nøyaktig samme måte. Den får ikke nye kriterier.
Men den vil være raskere, ettersom den fanger opp tilstander som ikke oppfyller kravene

Mitt svar:

## Hva endret jeg, og hvorfor?
Jeg endret på metoden CanLaunch(). Nå fanger den opp usanne kriterier ved check-en og sender tilbake et bool.
Er også lettere å lese, ettersom den forklarer individuelle kriterer bedre

## Hva trenger jeg mer øving på?
føler meg ganske komfortabel på tidlig retur