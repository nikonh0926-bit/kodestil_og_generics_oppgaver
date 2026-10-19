
var recorderString = new Recorder<string>();
var recorderInt = new Recorder<int>();

Console.WriteLine(recorderInt.Count);
Console.WriteLine(recorderInt.Contains(7));

recorderString.Add("Orbit");
recorderInt.Add(7);
recorderInt.Add(7);

Console.WriteLine(recorderString.Count);
Console.WriteLine(recorderString.Contains("Orbit"));

Console.WriteLine(recorderInt.Count);
Console.WriteLine(recorderInt.Contains(7));

recorderInt.Clear();

Console.WriteLine(recorderString.Count);
Console.WriteLine(recorderString.Contains("Orbit"));

Console.WriteLine(recorderInt.Count);
Console.WriteLine(recorderInt.Contains(7));