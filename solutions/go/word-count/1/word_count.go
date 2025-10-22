package wordcount

import (
    "regexp"
    "strings"
    "unicode"
)

type Frequency map[string]int

func WordCount(phrase string) Frequency {
	re := regexp.MustCompile(`[\s,]+`)
    words := re.Split(phrase, -1)
    result := make(map[string]int)
    for _, word := range words {
        if len(word) > 0 {
            runes := []rune(word)
            var wordToAdd strings.Builder
            for i, r := range runes {
                if (i == 0 || i == len(runes) - 1) && (r == '\'' || r == '"') {
                    continue
                }
                if r == '\'' || unicode.IsLetter(r) || unicode.IsDigit(r) {
                wordToAdd.WriteRune(unicode.ToLower(r))
            	}
            }
            w := wordToAdd.String()
            result[w] += 1
        }
    }
    return Frequency(result)
}
