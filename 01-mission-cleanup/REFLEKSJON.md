# Refleksjon — Mission Cleanup


## Plan før koding

- 
Gjøre koden mer lesbar.
Fjerne unødvendige kommentarer.
oppførsel må vær identisk etter endring.
## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|---|---|---|
|{"Ada", "Bo", "Cy" }|Crew 3 Ready |Crew 3 Ready |
|{"Ada", "Bo"}|Crew 2 Waiting |Crew 2 Waiting |
|{ }|Crew 0 Waiting |Crew 0 Waiting |

## Forklaring

Hvilken endring gjorde koden lettere å forstå uten å endre oppførselen?

Mitt svar:

## Hva endret jeg, og hvorfor?
Jeg endret navn på listen fra x til crewMembers. Det forklarer bedre hva listen inneholder. Og gjør det lettere å vite hvilken variabel man jobber med.

Jeg fjernet kommentarer som var rein beskrivelse på hva koden er.
Jeg beholdt kommentarer som forklarer hensikten med koden. I dette tilfelle spesielt, hvor det handler om sikkerhet. 

Ga litt mer rom mellom hver sekvens av koden. Dette gjør den enklere å lese.
Og jeg satt blokkene til if/else under hver statement. Det gjør det enklere og se hva som skjer i hver enkelt blokk

## Hva trenger jeg mer øving på?
Føler meg ganske komfortabel med og gi navn til variabler og gi nok rom for og gjøre koden lesbar