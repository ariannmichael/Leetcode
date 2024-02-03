func containsDuplicate(nums []int) bool {
	count := make(map[int]bool, len(nums))

	for _, x := range nums {
		if count[x] {
			return true
		} else {
			count[x] = true
		}
	}

	return false
}