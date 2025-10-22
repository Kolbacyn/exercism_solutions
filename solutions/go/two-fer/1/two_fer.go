// Package twofer initialize function ShareWith.
package twofer

import (
    "fmt"
)

// ShareWith accepts one argument name of string type and 
// returns string value.
func ShareWith(name string) string {
    if name != "" {
        return fmt.Sprintf("One for %v, one for me.", name)
    }
	return "One for you, one for me."
}
