# Refleksjon — Signal Types

## Plan før koding

- 
typer:
Label = string
retries = var - en uspesifisert type som blir bestemt når den får en verdi
messages = List<string> - en liste av string
result = string
## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|---|---|---|
| opprinnelig program | Echo: READY | - forventet oppførsel
| messages.ADD(42); | messages er en liste av string, den vil ikke godta et tall og vil gi feilmelding. | Build error - forventet oppførsel |
| retries = "three"; | retries er en var, men har fått verdi 3 som er en integer. Den godtar ikke string | Build error - forventet oppførsel |
| messages.ADD("en gyldig melding"); Console.WriteLine(messages.Count); | legger til en gyldig string i messages, Count blir 2 | 2 |


## Forklaring

Er string i List<string> en tekstverdi eller en type? Hvorfor kan ikke var retries senere bli tekst?

Mitt svar:
string er typen som List<string> inneholder
retries er en var. Det betyr at typen blir bestemt når den får en verdi.

Hvis man skriver var retries = 3; blir variabelen bestemt som en integer.
Man kan ikke implisitt caste string til en integer

## Hva endret jeg, og hvorfor?
jeg la til linjene 
messages.ADD("en gyldig melding"); 
Console.WriteLine(messages.Count);

Jeg gjorde det for og legge til en string på messages.
Og for og vise antall strings i messages

## Hva trenger jeg mer øving på?
føler meg ganske komfortabel med datatyper, casting og parsing