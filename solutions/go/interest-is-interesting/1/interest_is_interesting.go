package interest

func InterestRate(balance float64) float32 {
	switch {
    case balance < 0:
        return float32(3.213)
    case balance < 1000:
        return float32(0.5)
    case balance < 5000:
        return float32(1.621)
    default:
        return float32(2.475)
    }
}

func Interest(balance float64) float64 {
    rate := InterestRate(balance)
    return balance * float64(rate) / 100
}

func AnnualBalanceUpdate(balance float64) float64 {
	return balance + Interest(balance)
}

func YearsBeforeDesiredBalance(balance, targetBalance float64) int {
    years := 0
    current := balance
    for current < targetBalance {
        current += Interest(current)
        years++
    }
    return years
}
