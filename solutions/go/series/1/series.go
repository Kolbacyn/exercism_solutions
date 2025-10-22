package series

func All(n int, s string) []string {
	result := make([]string, 0)
    m := len(s)
    if n > m {
        return result
    }
    left, right := 0, n
    for right <= m {
        result = append(result, s[left:right])
        left++
        right++
    }
    return result
}

func UnsafeFirst(n int, s string) string {
	m := len(s)
    if n > m {
        return ""
    }
    left, right := 0, n
    return s[left:right]
}
