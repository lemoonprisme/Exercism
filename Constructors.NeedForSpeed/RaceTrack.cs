namespace Constructors.NeedForSpeed;

public class RaceTrack
{
    private readonly int _distance;

    public RaceTrack(int distance){
        _distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(!car.BatteryDrained()){
            car.Drive();
        }
        return _distance <= car.DistanceDriven();
    }
}