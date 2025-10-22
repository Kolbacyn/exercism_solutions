package romannumerals

import (
    "errors"
)

func ToRomanNumeral(input int) (string, error) {
    romanValues := []struct {
		Value  int
		Symbol string
	}{
		{1000, "M"},
		{900, "CM"},
		{500, "D"},
		{400, "CD"},
		{100, "C"},
		{90, "XC"},
		{50, "L"},
		{40, "XL"},
		{10, "X"},
		{9, "IX"},
		{5, "V"},
		{4, "IV"},
		{1, "I"},
	}
    if input <= 0 || input > 3999  {
        return "", errors.New("Input should be a positive number above zero.")
    }
    romanNum := ""
    for _, roman := range romanValues {
		for input >= roman.Value {
			romanNum += roman.Symbol
			input -= roman.Value
		}
	}
	return romanNum, nil
}
