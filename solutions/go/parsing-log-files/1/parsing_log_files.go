package parsinglogfiles

import (
    "regexp"
)

func IsValidLine(text string) bool {
	re := regexp.MustCompile(`^\[(TRC|DBG|INF|WRN|ERR|FTL)\]`)
    return re.MatchString(text)
}

func SplitLogLine(text string) []string {
	var separatorRegexp = regexp.MustCompile(`<[\~\*\=\-]*>`)
    return separatorRegexp.Split(text, -1)
}

func CountQuotedPasswords(lines []string) int {
	re := regexp.MustCompile(`(?i)"[^"]*password[^"]*"`)
    counter := 0
    for _, line := range lines {
        if re.MatchString(line) {
            counter++
        }
    }
    return counter
}

func RemoveEndOfLineText(text string) string {
	re := regexp.MustCompile(`end-of-line[0-9]+`)
    s := re.ReplaceAllString(text, "")
    return s
}

func TagWithUserName(lines []string) []string {
	re := regexp.MustCompile(`User\s+(\S+)`)
    for i, line := range lines {
        matches := re.FindStringSubmatch(line)
        if len(matches) >= 2 {
            username := matches[1]
            lines[i] = "[USR] " + username + " " + line
        }
    }
    return lines
}
