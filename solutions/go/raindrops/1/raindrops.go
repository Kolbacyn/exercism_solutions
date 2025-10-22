package raindrops

import (
    "strconv"
)

// Function Convert accepts number argument of integer type and
// returns string value.
func Convert(number int) string {
	result := ""
    if number % 3 == 0 {
        result += "Pling"
    }
    if number % 5 == 0 {
        result += "Plang"
    }
    if number % 7 == 0 {
        result += "Plong"
    }
    if result == ""{
        result += strconv.Itoa(number)
    }
    return result
}
