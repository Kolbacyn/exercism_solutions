package chessboard

// Declare a type named File which stores if a square is occupied by a piece - this will be a slice of bools
type File []bool

// Declare a type named Chessboard which contains a map of eight Files, accessed with keys from "A" to "H"
type Chessboard map[string]File

// CountInFile returns how many squares are occupied in the chessboard,
// within the given file.
func CountInFile(cb Chessboard, file string) int {
	result := 0
    for _, v := range(cb[file]) {
        if v {
            result++
        }
    }
    return result
}

// CountInRank returns how many squares are occupied in the chessboard,
// within the given rank.
func CountInRank(cb Chessboard, rank int) int {
	result := 0
    if rank < 1 || rank > 8 {
        return result
    }
    for _, v := range(cb) {
        if v[rank - 1] {
            result++
        }
    }
    return result
}

// CountAll should count how many squares are present in the chessboard.
func CountAll(cb Chessboard) int {
	return len(cb) * len(cb["A"])
}

// CountOccupied returns how many squares are occupied in the chessboard.
func CountOccupied(cb Chessboard) int {
    result := 0
	for k, _ := range(cb) {
        result += CountInFile(cb, k)
    }
    return result
}
