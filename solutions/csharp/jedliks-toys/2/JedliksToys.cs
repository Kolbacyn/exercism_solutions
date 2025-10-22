class RemoteControlCar
{
    public int Distance {get; private set; } = 0;
    public int Battery { get; private set; } = 100;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {Distance} meters";

    public string BatteryDisplay()
    {
        if (Battery <= 0)
        {
            return "Battery empty";
        }
        else
        {
            return $"Battery at {Battery}%";
        }
        
    }

    public void Drive()
    {
        if (Battery > 0)
        {
            Distance += 20;
            Battery -= 1;
        }
    }
}
