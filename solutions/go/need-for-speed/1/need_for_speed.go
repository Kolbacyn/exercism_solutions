package speed

import (
    "fmt"
)

type Car struct {
    battery int
    batteryDrain int
    speed int
    distance int
}

func NewCar(speed, batteryDrain int) Car {
    return Car{battery: 100, batteryDrain: batteryDrain, speed: speed}
}

type Track struct {
    distance int
}

func NewTrack(distance int) Track {
    return Track{distance: distance}
    
}

func Drive(car Car) Car {
	if car.battery < car.batteryDrain {
        fmt.Println("Not enought battery to drive")
        return car
    }
    car.distance += car.speed
    car.battery -= car.batteryDrain
    return car
}

func CanFinish(car Car, track Track) bool {
	maxDrives := car.battery / car.batteryDrain
    maxDistance := maxDrives * car.speed
    return maxDistance >= track.distance
}
