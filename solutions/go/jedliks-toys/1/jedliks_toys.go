package jedlik

import (
    "fmt"
)


func (car *Car) Drive() {
	if car.battery < car.batteryDrain {
        fmt.Println("Not enough battery to drive")
        return
    }
    car.distance += car.speed
    car.battery -= car.batteryDrain
}

func (car Car) CanFinish(trackDistance int) bool {
	maxDrives := car.battery / car.batteryDrain
    maxDistance := maxDrives * car.speed
    return maxDistance >= trackDistance
}

func (car Car) DisplayDistance() string {
    distance := fmt.Sprintf("Driven %v meters", car.distance)
    return distance
}

func (car Car) DisplayBattery() string {
    battery := fmt.Sprintf("Battery at %v%%", car.battery)
    return battery
}

