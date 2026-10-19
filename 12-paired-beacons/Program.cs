
var stringPair = new Pair<string>("første", "andre");
var intPair = new Pair<int>(1, 2);

var stringPair2 = new Pair<string>("tredje", "fjerde");

var beacon1 = new Beacon("beacon 1");
var beacon2 = new Beacon("beacon 2");
var beacon = new Pair<string>(beacon1.Name, beacon2.Name);


PairDisplay.ShowPair<string>(stringPair);
PairDisplay.ShowPair<string>(stringPair2);
PairDisplay.ShowPair<int>(intPair);
PairDisplay.ShowPair<string>(beacon);