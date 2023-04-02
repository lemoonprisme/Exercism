namespace Classes.ElonsToys;

class RemoteControlCar
{
    private int _distance;
    private int _batteryPercentage = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distance} meters";
    }

    public string BatteryDisplay()
    {
        return _batteryPercentage <= 0 ? "Battery empty" : $"Battery at {_batteryPercentage}%";
    }

    public void Drive()
    {
        if(_batteryPercentage > 0){
            _distance += 20;
            _batteryPercentage -= 1;
        }
    
    }
}