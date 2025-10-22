// Package proverb contains function proverb.
package proverb

import (
    "fmt"
)

// Proverb accepts rhyme argument of slice type and returns
// slice of strings.
func Proverb(rhyme []string) []string {
	n := len(rhyme)
    if n == 0 {
        return []string{}
    }
    if n == 1 {
        return []string{fmt.Sprintf("And all for the want of a %v.", rhyme[0])}
    }
    left, right := 0, 1
    poem := make([]string, 0, n)
    for right < n {
        str := fmt.Sprintf("For want of a %v the %v was lost.", rhyme[left], rhyme[right])
        poem = append(poem, str)
        left++
        right++
    }
    last := fmt.Sprintf("And all for the want of a %v.", rhyme[0])
    poem = append(poem, last)
    return poem
}
