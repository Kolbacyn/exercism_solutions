package collatzconjecture

import (
    "errors"
)

func CollatzConjecture(n int) (int, error) {
    if n <= 0 {
        return 0, errors.New("n must be positive integer larger than 0")
    }
    iters := 0
	for n != 1 {
        if n % 2 == 0 {
            n /= 2
            iters++
        } else {
            n = n * 3 + 1
            iters++
        }
    }
    return iters, nil
}
