package cards

func FavoriteCards() []int {
	card := []int{2, 6, 9}
    return card
}

func GetItem(slice []int, index int) int {
	if index < 0 || index >= len(slice) {
        return -1
    } else {
        return slice[index]
    }
}

func SetItem(slice []int, index, value int) []int {
	if index < 0 || index >= len(slice) {
        if cap(slice) > len(slice) {
            slice = slice[:len(slice)+1]
            slice[len(slice)-1] = value
            return slice
        }
        return append(slice, value)
    }
    slice[index] = value
    return slice
}

func PrependItems(slice []int, values ...int) []int {
	if len(values) == 0 {
        return slice
    }
    result := make([]int, 0,  len(slice) + len(values))
    result = append(result, values...)
    result = append(result, slice...)
    return result
}

func RemoveItem(slice []int, index int) []int {
	if index < 0 || index >= len(slice) {
        return slice
    }
    return append(slice[:index], slice[index+1:]...)
}
