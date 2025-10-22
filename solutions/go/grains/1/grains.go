package grains

import (
    "errors"
)

func Square(number int) (uint64, error) {
    if number <= 0 || number > 64 {
        return 0, errors.New("Number must be positive integer from 1 to 64")
    }
    grains := uint64(1) << (number - 1)
    return grains, nil
}

func Total() uint64 {
	var totalGrains uint64 = 0
    for i := 0; i < 64; i++ {
        totalGrains += uint64(1) << i
    }
    return totalGrains
}
