package isogram

import (
    "unicode"
)

func IsIsogram(word string) bool {
    wordSet := make(map[rune]bool)
	for _, r := range word {
        if unicode.IsDigit(r) {
            return false
        }
        if unicode.IsLetter(r) {
            lower := unicode.ToLower(r)
            if wordSet[lower] {
                return false
            }
            wordSet[lower] = true
        }
    }
    return true
}
