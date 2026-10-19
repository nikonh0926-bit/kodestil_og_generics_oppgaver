

FlightLog log = new FlightLog();
var secondLog = new FlightLog();

Console.WriteLine(log.Count);
Console.WriteLine(secondLog.Count);

log.Add("Launch");
log.Add("Orbit");

secondLog.Add("Launch");
secondLog.Add("Orbit");

Console.WriteLine(log.Count);

log.Clear();

secondLog.Add("Landing");

Console.WriteLine(log.Count);
Console.WriteLine(secondLog.Count);

log.Clear();
secondLog.Clear();

secondLog.Add("Lanch");

Console.WriteLine(secondLog.Count);