// Package leap contains IsLeapYear function using for to define
// if the year is a leap year or not.
package leap

// IsLeapYear function accepts one argument year of integer type and
// returns boolean value.
func IsLeapYear(year int) bool {
	if year % 400 == 0  {
        return true
    }
    if year % 100 == 0 {
        return false
    }
    if year % 4 == 0 {
        return true
    }
    return false
    
}
