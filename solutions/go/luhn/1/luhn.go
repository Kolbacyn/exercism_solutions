package luhn

import (
    "unicode"
)

func Valid(id string) bool {
    digits := []rune{}
    for _, r := range id {
        if unicode.IsSpace(r) {
            continue
        }
        if !unicode.IsDigit(r) {
            return false
        }
        digits = append(digits, r)
    }

    if len(digits) <= 1 {
        return false
    }

    sum := 0
    double := false

    // Process digits from right to left
    for i := len(digits) - 1; i >= 0; i-- {
        digit := int(digits[i] - '0')
        if double {
            digit *= 2
            if digit > 9 {
                digit -= 9
            }
        }
        sum += digit
        double = !double
    }

    return sum%10 == 0
}
