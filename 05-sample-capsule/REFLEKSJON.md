# Refleksjon — Sample Capsule

## Plan før koding

- 
sett konstruktoren til og sette verdier ved oppretting av objektet.
få Read() til og returnere verdien _content til objektet
få Replace() til og erstatte _content med ønsket verdi

## Testlogg

| Handling | Forventet innhold |
|---|---|

## Forklaring

Hvorfor skal _content være et instansfelt og ikke static?

Mitt svar:
fordi vær enkelt objekt av typen StringCapsule skal ha sin egen instans av _content.

Hvis _content var statisk. Ville alle objekter av den typen dele en _content verdi.

Eksempel:

private static string _content = "";

first = "rock"
second = "ice"

second.Replace("dust");

first = "dust"
second = "dust"


## Hva endret jeg, og hvorfor?
Jeg fullførte konstruktoren
_content = content; - da blir verdien satt på opprettelsen av objektet og man kan initialisere den med var first = new StringCapsule("dust")

Jeg endret Read() så den returnerer verdien _content fra objektet
return _content; - hvis man gjør Console.WriteLine(first.Read()); vil verdien _content for det objektet bli skrivet til terminalen

jeg fullførte Replace(string content) så den erstatter _content med ny verdi
_content = content; - ved first.Replace("rock") vil _content for objektet bli erstattet med "rock"

## Hva trenger jeg mer øving på?
føler meg ganske komfortabel med klasser, statiske- og private felt sammt instansemetoder
