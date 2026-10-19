public class StringCapsule
{
    private static string _content = "";

    public StringCapsule(string content)
    {
        // TODO: Oppbevar argumentet i feltet.
        _content = content;
    }

    public string Read()
    {
        // TODO: Returner objektets innhold. Dette er en midlertidig returverdi.
        return _content;
    }

    public void Replace(string content)
    {
        // TODO: Oppdater feltet.
        _content = content;
    }
}
