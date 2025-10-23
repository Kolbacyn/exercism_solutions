class RemoteControlCar
{
    private int speed;
    private int battery;
    private int batteryDrain;
    private int distanceDriven;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.distanceDriven = 0;
        this.battery = 100;
    }

    public int Speed => speed;
    public int Battery => battery;
    public int BatteryDrain => batteryDrain;
    
    public bool BatteryDrained() => battery < batteryDrain;

    public int DistanceDriven() => distanceDriven;

    public void Drive()
    {
        if (!BatteryDrained() && battery >= batteryDrain)
        {
            distanceDriven += speed;
            battery -= batteryDrain;
        }
        else
        {
            battery = 0;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int distance;
    
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int maxDrives = car.Battery / car.BatteryDrain;
        int maxDistance = maxDrives * car.Speed;
        return maxDistance >= distance;
    }
}
