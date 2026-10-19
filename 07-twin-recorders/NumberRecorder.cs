public class NumberRecorder
{
    private List<int> _items = new List<int>(); // lik, men med annen type for _items List<int>
    public int Count { get { return _items.Count; } } // identisk
    public void Add(int item) { _items.Add(item); } // lik, men med annen type for Add() metode
    public bool Contains(int item) { return _items.Contains(item); } // lik, men med annen type for Contains() metode
    public void Clear()
    {
        _items.Clear();
    }
}
