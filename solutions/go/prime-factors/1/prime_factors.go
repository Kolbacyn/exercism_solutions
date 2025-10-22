package prime

func Factors(n int64) []int64 {

    primeFactors := make([]int64, 0)
	var divisor int64 = 2

    for divisor*divisor <= n {
        for n%divisor == 0 {
            primeFactors = append(primeFactors, divisor)
            n /= divisor
        }
        if divisor == 2 {
            divisor = 3
        } else {
            divisor += 2 // increment by 2 to check only odd numbers
        }
    }

    if n > 1 {
        primeFactors = append(primeFactors, n)
    }

    return primeFactors
}
