namespace Constructor.RailFenceCipher;

public class RailFenceCipher
{
    private readonly int _rails;

    public RailFenceCipher(int rails)
    {
        _rails = rails;
    }

    public string Encode(string input)
    {
        var rows = new List<string>(_rails);
        var i = 0;
        var encodedMessage = "";
        var reverser = false;
        foreach(var c in input)
        {
            if (i == _rails || i == 0) reverser = !reverser;
            rows[i] += char.ToString(c);
            if (reverser)
            {
                i++;
            }
            else
            {
                i--;
            }
        }
        foreach(var str in rows) encodedMessage += str;
        return encodedMessage;
    }

    public string Decode(string input)
    {
        return "232";
    }
}
