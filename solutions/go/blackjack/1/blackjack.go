package blackjack

func ParseCard(card string) int {
	cards := map[string]int{
        "ace": 11,
        "king": 10,
        "queen": 10,
        "jack": 10,
        "ten": 10,
        "nine": 9,
        "eight": 8,
        "seven": 7,
        "six": 6,
        "five": 5,
        "four": 4,
        "three": 3,
        "two": 2,
    }
    if val, ok := cards[card]; ok {
        return val
    }
    return 0
}


func FirstTurn(card1, card2, dealerCard string) string {
	myCards := ParseCard(card1) + ParseCard(card2)
    switch {
    case myCards == 22:
    	return "P"
    case myCards == 21 && ParseCard(dealerCard) >= 10:
        return "S"
    case myCards >= 17 && myCards <= 20:
        return "S"
    case myCards >= 12 && myCards <= 16 && ParseCard(dealerCard) >= 7:
        return "H"
    case myCards >= 12 && myCards <= 16 && ParseCard(dealerCard) < 7:
        return "S"
    case myCards <= 11:
        return "H"
    default:
        return "W"
    }
}
