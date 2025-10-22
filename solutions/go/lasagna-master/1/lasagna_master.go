package lasagna

func PreparationTime(layers []string, time int) int {
    if time == 0 {
        time = 2
    }
    return time * len(layers)
}

func Quantities(layers []string) (int, float64) {
    sauce := 0.0
    noodles := 0
    for i := 0; i < len(layers); i++ {
        if layers[i] == "sauce" {
            sauce += 0.2
        }
        if layers[i] == "noodles" {
            noodles += 50
        }
    }
    return noodles, sauce
}

func AddSecretIngredient(friendsList, myList []string)  {
    myList[len(myList)-1] = friendsList[len(friendsList)-1]
}

func ScaleRecipe(quantities []float64,  portions int) []float64 {
    scaledQuantities := make([]float64, len(quantities))
    for i, q := range quantities {
        scaledQuantities[i] = (q / 2.0) * float64(portions)
    }
    return scaledQuantities
}
