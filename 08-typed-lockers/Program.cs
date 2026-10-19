
Console.WriteLine("Typed Lockers");
// TODO: Opprett, bruk og test to skap med ulike typeargumenter.

var name = new Locker<string>("Beacon");
var id = new Locker<int>(42);

Console.WriteLine(name.Read());
Console.WriteLine(id.Read());

name.Replace("Relay");
id.Replace(99);

Console.WriteLine(name.Read());
Console.WriteLine(id.Read());


//id.Replace("test"); - får feilmelding fordi Locker<int> forventer en integer