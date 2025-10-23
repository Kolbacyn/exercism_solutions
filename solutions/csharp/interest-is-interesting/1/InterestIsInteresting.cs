static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        switch (balance)
        {
            case < 0:
                return 3.213f;
            case < 1000:
                return 0.5f;
            case >= 1000 and < 5000:
                return 1.621f;
            default:
                return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        float rate = InterestRate(balance);
        return balance * (decimal)rate/100m;
    }

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        decimal current = balance;
        while (current < targetBalance)
        {
            current += Interest(current);
            years++;
        }
        return years;
    }
}
