package birdwatcher

func TotalBirdCount(birdsPerDay []int) int {
    birdsCount := 0
	for i := 0; i < len(birdsPerDay); i++ {
        birdsCount += birdsPerDay[i]
    }
    return birdsCount
}

func BirdsInWeek(birdsPerDay []int, week int) int {
    countBirds := 0
    first, last := (week * 7) - 7, week * 7
	for i := 0; i < len(birdsPerDay); i++ {
        if i >= first && i < last {
            countBirds += birdsPerDay[i]
        }
    }
    return countBirds
}

func FixBirdCountLog(birdsPerDay []int) []int {
	for i := 0; i < len(birdsPerDay); i += 2 {
        birdsPerDay[i] += 1
    }
    return birdsPerDay
}
