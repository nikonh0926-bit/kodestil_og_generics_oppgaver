public class SignalPrinter
{
    public static void PrintList<T>(List<T> items)
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }
}
