package atbash

import (
    "strings"
    "unicode"
)

func Atbash(s string) string {
    var builder strings.Builder
    count := 0
    var encodedRunes []rune
    for _, r := range strings.ToLower(s) {
        switch {
        case unicode.IsLetter(r):
            encoded := 'z' - (r - 'a')
            encodedRunes = append(encodedRunes, encoded)
            count++
        case unicode.IsDigit(r):
            encodedRunes = append(encodedRunes, r)
            count++
        }
    }
    for i, r := range encodedRunes {
        if i > 0 && i%5 == 0 {
            builder.WriteRune(' ')
        }
        builder.WriteRune(r)
    }

    return builder.String()
}
