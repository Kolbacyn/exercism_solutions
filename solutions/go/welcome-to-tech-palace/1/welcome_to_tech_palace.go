package techpalace

import (
    "fmt"
    "strings"
)

func WelcomeMessage(customer string) string {
	return fmt.Sprintf("Welcome to the Tech Palace, %v", strings.ToUpper(customer))
}

func AddBorder(welcomeMsg string, numStarsPerLine int) string {
	border := strings.Repeat("*", numStarsPerLine)
    response := []string{
        border,
        welcomeMsg,
        border,
    }
    return strings.Join(response, "\n")
}

func CleanupMessage(oldMsg string) string {
	noStars := strings.ReplaceAll(oldMsg, "*", " ")
    noSpaces := strings.TrimSpace(noStars)
    return noSpaces
}
