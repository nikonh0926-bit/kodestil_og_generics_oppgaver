public class TextRecorder
{
    private List<string> _items = new List<string>(); // lik, men med annen type for _items List<string>
    public int Count { get { return _items.Count; } } // identisk
    public void Add(string item) { _items.Add(item); } // lik, men med annen type for Add() metode
    public bool Contains(string item) { return _items.Contains(item); } // lik, men med annen type for Contains() metode
    public void Clear()
    {
        _items.Clear();
    }
}
