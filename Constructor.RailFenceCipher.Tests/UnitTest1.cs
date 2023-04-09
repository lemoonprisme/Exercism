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
    [Fact]
    public void Test2()
    {
        var msg = "TEITELHDVLSNHDTISEIIEA";
        var decoder = new RailFenceCipher(3);
        var expected = "THEDEVILISINTHEDETAILS";

        var actual = decoder.Decode(msg); 
        
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test3()
    {
        var msg = "EIEXMSMESAORIWSCE";
        var decoder = new RailFenceCipher(5);
        var expected = "EXERCISMISAWESOME";

        var actual = decoder.Decode(msg); 
        
        Assert.Equal(expected, actual);
    }
}