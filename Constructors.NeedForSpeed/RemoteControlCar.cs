namespace Constructors.NeedForSpeed;

public class RemoteControlCar
{

    private readonly int _speed;
    private readonly int _batteryDrain;
    private int _distance = 0;
    private int _charge = 100;
    
    public RemoteControlCar(int speed, int batteryDrain){
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return _charge - _batteryDrain < 0;
    }

    public int DistanceDriven()
    {
        return _distance;
    }

    public void Drive()
    {
        if(_charge - _batteryDrain < 0) return;
        _distance += _speed;
        _charge -= _batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}