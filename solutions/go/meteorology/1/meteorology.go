package meteorology

import (
    "fmt"
)

type TemperatureUnit int

const (
	Celsius    TemperatureUnit = 0
	Fahrenheit TemperatureUnit = 1
)

// Add a String method to the TemperatureUnit type
func (tu TemperatureUnit) String() string {
    grades := []string{"°C", "°F"}
    return grades[tu]
}

type Temperature struct {
	degree int
	unit   TemperatureUnit
}

// Add a String method to the Temperature type
func (t Temperature) String() string {
    return fmt.Sprintf("%v %v", t.degree, t.unit)
}

type SpeedUnit int

const (
	KmPerHour    SpeedUnit = 0
	MilesPerHour SpeedUnit = 1
)

// Add a String method to SpeedUnit
func (su SpeedUnit) String() string {
    speeds := []string{"km/h", "mph"}
    return speeds[su]
} 

type Speed struct {
	magnitude int
	unit      SpeedUnit
}

// Add a String method to Speed
func (s Speed) String() string {
    return fmt.Sprintf("%v %v", s.magnitude, s.unit)
}

type MeteorologyData struct {
	location      string
	temperature   Temperature
	windDirection string
	windSpeed     Speed
	humidity      int
}

// Add a String method to MeteorologyData
func (m MeteorologyData) String() string {
    temp := m.temperature.String()
    speed := m.windSpeed.String()
    return fmt.Sprintf("%v: %v, Wind %v at %v, %v%% Humidity", m.location, temp, m.windDirection, speed, m.humidity)
}
