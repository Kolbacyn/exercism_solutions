package dndcharacter

import (
    "math"
    "math/rand"
    "sort"
)

type Character struct {
	Strength     int
	Dexterity    int
	Constitution int
	Intelligence int
	Wisdom       int
	Charisma     int
	Hitpoints    int
}

// Modifier calculates the ability modifier for a given ability score
func Modifier(score int) int {
    modifier := math.Floor(float64(score-10) / 2)
	return int(modifier)
}

// Ability uses randomness to generate the score for an ability
func Ability() int {
	rolls := make([]int, 0, 4)
    for i := 0; i < 4; i++ {
        roll := rand.Intn(6) + 1
        rolls = append(rolls, roll)
    }
    sort.Ints(rolls)
    return rolls[1] + rolls[2] + rolls[3]
}

// GenerateCharacter creates a new Character with random scores for abilities
func GenerateCharacter() Character {
	char := Character{
        Strength:     Ability(),
    	Dexterity:    Ability(),
    	Constitution: Ability(),
    	Intelligence: Ability(),
    	Wisdom:       Ability(),
    	Charisma:     Ability(),
    }
    char.Hitpoints = 10 + Modifier(char.Constitution)
    return char
}
