class WeighingMachine
{
    private int precision;
    private double weight;
    private double tareAdjustment;
    public int Precision
    {
        get { return precision; }
    }

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Argument couldn't be negative");
            }
            weight = value;
        }
    }

    public string DisplayWeight
    {
        get
        {
            return (weight - tareAdjustment).ToString($"F{precision}") + " kg";
        }
    }

    public double TareAdjustment
    {
        get { return tareAdjustment; }
        set { tareAdjustment = value; }
    }

    public WeighingMachine(int precision)
    {
        this.precision = precision;
        tareAdjustment = 5;
        weight = 0;
    }
}
