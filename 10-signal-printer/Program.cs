
List<string> messages = new List<string> { "SOS", "ACK" };
var numbers = new List<int> {1, 2, 3};
var emptyList = new List<int>();

SignalPrinter.PrintList(messages);
SignalPrinter.PrintList(numbers);
SignalPrinter.PrintList(emptyList);