// Package acronym contains function which converts long strings
// into acronyms.
package acronym

import (
    "regexp"
    "strings"
    "unicode"
)

// Abbreviate accepts one argument s of string type and
// returns its acronym as a string value.
func Abbreviate(s string) string {
    re := regexp.MustCompile(`[ -]+`)
    parts := re.Split(s, -1)
    acronym := ""
    for _, v := range parts {
        if len(v) > 0 {
            runes := []rune(v)
            for _, r := range runes {
                if unicode.IsLetter(r) {
                    acronym += strings.ToUpper(string(r))
                    break
                }
            }
        }
    }
	return acronym
}
