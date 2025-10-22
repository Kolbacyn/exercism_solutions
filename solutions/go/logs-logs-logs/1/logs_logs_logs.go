package logs

import (
    "unicode/utf8"
)

func Application(log string) string {
	for _, r := range log {
        switch r {
        case '❗':
        	return "recommendation"
        case '🔍':
        	return "search"
        case '☀':
        	return "weather"
        }
    }
    return "default"
}

func Replace(log string, oldRune, newRune rune) string {
	response := ""
    zero := 0
    for i, s := range log {
        if s == oldRune {
            response += log[zero:i]
            response += string(newRune)
            zero = i + len(string(s))
        }
    }
    response += log[zero:]
    return response
}

func WithinLimit(log string, limit int) bool {
	return utf8.RuneCountInString(log) <= limit
}
