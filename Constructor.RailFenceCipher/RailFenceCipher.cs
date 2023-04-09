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
        var rows = new string[_rails];
        var i = 0;
        var encodedMessage = "";
        var reserver = false;
        foreach(var c in input)
        {
            if (i == _rails - 1 || i == 0) reserver = !reserver;
            rows[i] += c;
            if (reserver) i++;
            else i--;
        }
        foreach(var str in rows) encodedMessage += str;
        return encodedMessage;
    }
    public string Decode(string input)
    {
        var n = 0;
        var i = 0;
        var j = 0;
        var k = 0;
        var msg = new char[input.Length];
        while (j<msg.Length)
        {
            
            k = 2 * n * (_rails - 1);
            if (k + i > msg.Length)
            {
                n = 0;
                i++;
            }
            k = 2 * n * (_rails - 1);
            
            if (i == 0 || i == _rails - 1)
            {
                msg[i + k] = input[j];
                j++;
                n++;
            }

            if (i != 0 && i != _rails - 1)
            {
                if (k - i > 0 && k-i < msg.Length)
                {
                    msg[k - i] = input[j];
                    j++;
                }

                if (k + i < msg.Length)
                {
                    msg[k + i] = input[j];
                    j++;
                }
                n++;
            }
        }

        return String.Join("",msg);
    }
}
