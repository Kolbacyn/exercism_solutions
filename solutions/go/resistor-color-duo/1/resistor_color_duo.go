package resistorcolorduo

var resistorColors = map[string]int{
    "black":  0,
    "brown":  1,
    "red":    2,
    "orange": 3,
    "yellow": 4,
    "green":  5,
    "blue":   6,
    "violet": 7,
    "grey":   8,
    "white":  9,
}

func colorNum(color string) int {
    return resistorColors[color]
}

// Value should return the resistance value of a resistor with a given colors.
func Value(colors []string) int {
	ohmQty := 0
    ohmQty += colorNum(colors[1]) + colorNum(colors[0]) * 10
    return ohmQty
}
