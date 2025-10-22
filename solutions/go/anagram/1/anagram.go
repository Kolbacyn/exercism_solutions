package anagram

import (
    "unicode"
)

// Detect finds all anagrams of subject in candidates.
// An anagram has the same counts of letters (case-insensitive Unicode-aware),
// but cannot be the same word as the subject (case-insensitive).
func Detect(subject string, candidates []string) []string {
    var words []string
    checkedSubject := CheckCandidate(subject)

    for _, candidate := range candidates {
        if caseInsensitiveEqual(subject, candidate) {
            continue
        }

        candidateMap := CheckCandidate(candidate)
        if mapsEqual(candidateMap, checkedSubject) {
            words = append(words, candidate)
        }
    }
    return words
}

// CheckCandidate returns a map[rune]int counting letters in candidate,
// case-insensitive using Unicode case folding.
// Non-letters are ignored.
func CheckCandidate(candidate string) map[rune]int {
    vocab := make(map[rune]int)

    for _, r := range candidate {
        if unicode.IsLetter(r) {
            lower := unicode.ToLower(r)  // better: consider using unicode.SimpleFold for full Unicode folding if needed
            vocab[lower]++
        }
    }
    return vocab
}

// mapsEqual compares two maps rune->int for equality.
func mapsEqual(a, b map[rune]int) bool {
    if len(a) != len(b) {
        return false
    }
    for k, v := range a {
        if vb, ok := b[k]; !ok || vb != v {
            return false
        }
    }
    return true
}

// caseInsensitiveEqual compares two strings ignoring case of letters, Unicode-aware.
func caseInsensitiveEqual(a, b string) bool {
    ra := []rune(a)
    rb := []rune(b)
    if len(ra) != len(rb) {
        return false
    }
    for i := range ra {
        if unicode.ToLower(ra[i]) != unicode.ToLower(rb[i]) {
            return false
        }
    }
    return true
}
