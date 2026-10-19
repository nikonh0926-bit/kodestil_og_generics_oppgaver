
History<string> historyString = new History<string>();
var historyInt = new History<int>();


historyString.Add("Launch");
historyString.Add("Orbit");
List<string> snapshotString = historyString.GetSnapshot();
Console.WriteLine($"string: {historyString.Count} kopi: {snapshotString.Count}");


historyString.Add("Landing");
Console.WriteLine($"string: {historyString.Count} kopi: {snapshotString.Count}");


historyString.Clear();
Console.WriteLine($"string: {historyString.Count} kopi: {snapshotString.Count}");


historyInt.Add(1);
historyInt.Add(2);
var snapshotInt = historyInt.GetSnapshot();
Console.WriteLine($"Int: {historyInt.Count} kopi: {snapshotInt.Count}");

/*
endelig output blir:

string: 2 kopi: 2
string: 3 kopi: 2
string: 0 kopi: 2
Int: 2 kopi: 2
*/