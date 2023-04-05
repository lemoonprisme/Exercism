namespace Constructor.RailFenceCipher.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var msg = "HELLOWORLD";
        var encoder = new RailFenceCipher(4);
        var expected = "HOEWRLOLLD";
        
        var actual = encoder.Encode(msg);
        
        Assert.Equal(expected, actual);
    }
}