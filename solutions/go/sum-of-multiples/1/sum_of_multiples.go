package summultiples

func SumMultiples(limit int, divisors ...int) int {
	multiplesSet := make(map[int]struct{})

    for _, base := range divisors {
        if base <= 0 {
            continue // skip invalid base values
        }
        for multiple := base; multiple < limit; multiple += base {
            multiplesSet[multiple] = struct{}{}
        }
    }

    sum := 0
    for val := range multiplesSet {
        sum += val
    }

    return sum
}
