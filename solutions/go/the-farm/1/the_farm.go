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
// TODO: define the 'ValidateInputAndDivideFood' function
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
// Your first steps could be to read through the tasks, and create
// these functions with their correct parameter lists and return types.
// The function body only needs to contain `panic("")`.
//
// This will make the tests compile, but they will fail.
// You can then implement the function logic one by one and see
// an increasing number of tests passing as you implement more
// functionality.
