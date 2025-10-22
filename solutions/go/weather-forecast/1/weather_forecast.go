// Package weather initialize two variables
// and provide Forecast function.
package weather

// CurrentCondition variable uses by Forecast function.
var CurrentCondition string
// CurrentLocation variable uses by Forecast function.
var CurrentLocation string

// Forecast function accepts two arguments: CurrentCondition and CurrentLocation
// and returns integer value.
func Forecast(city, condition string) string {
	CurrentLocation, CurrentCondition = city, condition
	return CurrentLocation + " - current weather condition: " + CurrentCondition
}
