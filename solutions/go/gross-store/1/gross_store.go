package gross

func Units() map[string]int {
	units := map[string]int{"quarter_of_a_dozen": 3, "half_of_a_dozen": 6, "dozen": 12, "small_gross": 120, "gross": 144, "great_gross": 1728}
    return units
}

func NewBill() map[string]int {
    newBill := map[string]int{}
	return newBill
}

func AddItem(bill, units map[string]int, item, unit string) bool {
	value, ok := units[unit]
    if ok {
        bill[item] += value
        return true
    }
    return false
}

func RemoveItem(bill, units map[string]int, item, unit string) bool {
	value, ok := bill[item]
    if !ok {
        return false
    }
    unitValue, ok := units[unit]
    if !ok {
        return false
    }
    if value < unitValue {
        return false
    } else if value == unitValue {
        delete(bill, item)
        return true
    } else {
        bill[item] = value - unitValue
        return true
    }
}

func GetItem(bill map[string]int, item string) (int, bool) {
	qty, ok := bill[item]
    return qty, ok
}
