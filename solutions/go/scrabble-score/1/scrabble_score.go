package scrabble

import (
    "strings"
)

func Score(word string) int {
    result := 0
    for _, letter := range word {
        result += CheckLetter(letter)
    }
    return result
}

func CheckLetter(letter rune) int {
    letter = rune(strings.ToUpper(string(letter))[0])

    switch {
    case strings.ContainsRune("AEIOULNRST", letter):
        return 1
    case strings.ContainsRune("DG", letter):
        return 2
    case strings.ContainsRune("BCMP", letter):
        return 3
    case strings.ContainsRune("FHVWY", letter):
        return 4
    case strings.ContainsRune("K", letter):
        return 5
    case strings.ContainsRune("JX", letter):
        return 8
    case strings.ContainsRune("QZ", letter):
        return 10
    default:
        return 0
    }
}
