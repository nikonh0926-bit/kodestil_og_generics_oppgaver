public class FlightLog
{
    private List<string> _entries = new List<string>();

    public int Count
    {
        get
        {
            // TODO: Returner antallet i listen.
            return _entries.Count;
        }
    }

    public void Add(string entry)
    {
        // TODO: Legg til i den private listen.
        _entries.Add(entry);
    }

    public void Clear()
    {
        // TODO: Tøm listen.
        _entries.Clear();
    }
}
