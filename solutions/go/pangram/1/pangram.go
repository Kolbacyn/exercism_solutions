package pangram

import (
    "unicode"
)

func IsPangram(input string) bool {
	seen := make(map[rune]bool)
    for _, r := range input {
        if unicode.IsLetter(r) {
            lower := unicode.ToLower(r)
            seen[lower] = true
        }
    }
    return len(seen) == 26
}
