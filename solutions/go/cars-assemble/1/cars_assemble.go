package cars

func CalculateWorkingCarsPerHour(productionRate int, successRate float64) float64 {
	return float64(productionRate) * successRate / 100
}

func CalculateWorkingCarsPerMinute(productionRate int, successRate float64) int {
	hourly := CalculateWorkingCarsPerHour(productionRate, successRate)
    return int(hourly /60)
}

func CalculateCost(carsCount int) uint {
	groups := carsCount / 10
    individuals := carsCount % 10
    return uint(groups * 95000 + individuals * 10000)
}
