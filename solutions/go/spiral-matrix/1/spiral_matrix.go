package spiralmatrix

func SpiralMatrix(size int) [][]int {
	top, bottom := 0, size - 1
    left, right := 0, size - 1
    result := make([][]int, size)
    for i := range result {
        result[i] = make([]int, size)
    }
    counter := 1
    for top <= bottom && left <= right {
        for i := left; i <= right; i++ {
            result[top][i] = counter
            counter++
        }
        top++
        for i := top; i <= bottom ; i++ {
            result[i][right] = counter
            counter++
        }
        right--
        if top <= bottom {
            for i := right; i >= left; i-- {
                result[bottom][i] = counter
                counter++
            }
            bottom--
        }
        if left <= right {
            for i := bottom; i >= top; i-- {
                result[i][left] = counter
                counter++
            }
            left++
        }
    }
    return result
}
