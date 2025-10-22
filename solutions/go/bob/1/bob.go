package bob

import (
    "strings"
    "unicode"
)

// Hey returns Bob's response to a remark according to the rules:
// - If the remark is silence (empty or whitespace only), Bob replies "Fine. Be that way!".
// - If the remark is a yelled question (all caps question), Bob replies "Calm down, I know what I'm doing!".
// - If the remark is yelling (all caps, at least one letter), Bob replies "Whoa, chill out!".
// - If the remark is a question (ends with '?'), Bob replies "Sure.".
// - Otherwise, Bob replies "Whatever.".
func Hey(remark string) string {
    trimmed := strings.TrimSpace(remark)

    if trimmed == "" {
        return "Fine. Be that way!"
    }

    isQuestion := strings.HasSuffix(trimmed, "?")
    isYelling := isAllCaps(trimmed) && containsLetter(trimmed)

    switch {
    case isYelling && isQuestion:
        return "Calm down, I know what I'm doing!"
    case isYelling:
        return "Whoa, chill out!"
    case isQuestion:
        return "Sure."
    default:
        return "Whatever."
    }
}

// isAllCaps returns true if the string has at least one letter and all letters are uppercase.
func isAllCaps(s string) bool {
    hasLetter := false
    for _, r := range s {
        if unicode.IsLetter(r) {
            hasLetter = true
            if !unicode.IsUpper(r) {
                return false
            }
        }
    }
    return hasLetter
}

// containsLetter returns true if the string contains at least one letter.
func containsLetter(s string) bool {
    for _, r := range s {
        if unicode.IsLetter(r) {
            return true
        }
    }
    return false
}
