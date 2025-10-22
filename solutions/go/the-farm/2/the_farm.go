package thefarm

import(
    "errors"
    "fmt"
)

func DivideFood(f FodderCalculator, cows int) (float64, error) {
    amount, errAmount := f.FodderAmount(cows)
    if errAmount != nil {
        return 0, errAmount
    }
    amount = amount/float64(cows)
    factor, errFactor := f.FatteningFactor()
    if errFactor != nil {
        return 0, errFactor
    }
    return amount * factor, nil
}

func ValidateInputAndDivideFood(f FodderCalculator, cows int) (float64, error) {
    if cows <= 0 {
        return 0, errors.New("invalid number of cows")
    } else {
        return DivideFood(f, cows)
    }
    
}

type InvalidCowsError struct {
    message string
    details int
}

func (e *InvalidCowsError) Error() string {
    return fmt.Sprintf("%v cows are invalid: %s", e.details, e.message)
}

func ValidateNumberOfCows(cows int) (error) {
    if cows < 0 {
        return &InvalidCowsError{
            details: cows,
            message: "there are no negative cows",
        }
    }
    if cows == 0 {
        return &InvalidCowsError{
            details: cows,
            message: "no cows don't need food",
        }
    }
    return nil
}
