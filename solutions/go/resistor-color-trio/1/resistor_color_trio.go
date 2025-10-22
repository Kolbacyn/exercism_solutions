package resistorcolortrio

import(
    "fmt"
    "math"
)

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

var ranks = map[int]string{
    0: "",
    1: "kilo",
    2: "mega",
    3: "giga",
}

func colorNum(color string) int {
    return resistorColors[color]
}

// Label describes the resistance value given the colors of a resistor.
// The label is a string with a resistance value with an unit appended
// (e.g. "33 ohms", "470 kiloohms").
func Label(colors []string) string {
	ohmQty := 0
    ohmQty += colorNum(colors[1]) + colorNum(colors[0]) * 10
    zeroes := int(math.Pow10(colorNum(colors[2])))
    ohmQty = ohmQty * zeroes
    count := 0
    for ohmQty >= 1000 {
        ohmQty /= 1000
        count++
    }
    return fmt.Sprintf("%d %sohms", ohmQty, ranks[count])
}
