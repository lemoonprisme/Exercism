namespace Classes.SpaceAge;

public class SpaceAge
{
    private readonly double _spaceAge;
    // _mercury = Rotation period of Mercury / Rotation period of Earth 
    private readonly double _mercury = 0.2408467;
    private readonly double _venus = 0.61519726;
    private readonly double _earth = 1.0;
    private readonly double _mars = 1.8808158;
    private readonly double _jupiter = 11.862615;
    private readonly double _saturn = 29.447498;
    private readonly double _uranus = 84.016846;
    private readonly double _neptune = 164.79132;
    
    public SpaceAge(int seconds)
    {
        _spaceAge = seconds / 31557600d;
    }

    public double OnEarth()
    {
        return _spaceAge / _earth;
    }

    public double OnMercury()
    {
        return _spaceAge / _mercury;
    }

    public double OnVenus()
    {
        return _spaceAge / _venus;
    }

    public double OnMars()
    {
        return _spaceAge / _mars;
    }

    public double OnJupiter()
    {
        return _spaceAge / _jupiter;
    }

    public double OnSaturn()
    {
        return _spaceAge / _saturn;
    }

    public double OnUranus()
    {
        return _spaceAge / _uranus;
    }

    public double OnNeptune()
    {
        return _spaceAge / _neptune;
    }
}