namespace Classes.SpaceAge;

public class SpaceAge
{
    private readonly double _spaceAge;
    // _mercury = Rotation period of Mercury / Rotation period of Earth 
    private const double Mercury = 0.2408467;
    private const double Venus = 0.61519726;
    private const double Earth = 1.0;
    private const double Mars = 1.8808158;
    private const double Jupiter = 11.862615;
    private const double Saturn = 29.447498;
    private const double Uranus = 84.016846;
    private const double Neptune = 164.79132;

    public SpaceAge(int seconds)
    {
        _spaceAge = seconds / 31557600d;
    }

    public double OnEarth()
    {
        return _spaceAge / Earth;
    }

    public double OnMercury()
    {
        return _spaceAge / Mercury;
    }

    public double OnVenus()
    {
        return _spaceAge / Venus;
    }

    public double OnMars()
    {
        return _spaceAge / Mars;
    }

    public double OnJupiter()
    {
        return _spaceAge / Jupiter;
    }

    public double OnSaturn()
    {
        return _spaceAge / Saturn;
    }

    public double OnUranus()
    {
        return _spaceAge / Uranus;
    }

    public double OnNeptune()
    {
        return _spaceAge / Neptune;
    }
}