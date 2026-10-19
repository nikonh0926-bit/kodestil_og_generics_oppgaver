public class History<T>
{
    private List<T> _items = new List<T>();
    public int Count
    {
        get
        {
            // TODO: Les antallet fra samlingen.
            return _items.Count;
        }
    }
    public void Add(T item)
    {
        // TODO: Oppbevar elementet.
        _items.Add(item);
    }
    public List<T> GetSnapshot()
    {
        // TODO: Returner en samlingskopi med eksisterende elementer.
        return new List<T>(_items);
    }
    public void Clear()
    {
        // TODO: Tøm historikken.
        _items.Clear();
    }
}
