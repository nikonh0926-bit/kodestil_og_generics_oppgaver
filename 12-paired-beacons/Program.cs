
var stringPair = new Pair<string>("første", "andre");
var intPair = new Pair<int>(1, 2);

var stringPair2 = new Pair<string>("tredje", "fjerde");

var beacon1 = new Beacon("beacon 1");
var beacon2 = new Beacon("beacon 2");
var beacon = new Pair<Beacon>(beacon1, beacon2);


PairDisplay.ShowPair(stringPair);
PairDisplay.ShowPair(stringPair2);
PairDisplay.ShowPair(intPair);
Console.WriteLine(beacon.First.Name);
Console.WriteLine(beacon.Second.Name);