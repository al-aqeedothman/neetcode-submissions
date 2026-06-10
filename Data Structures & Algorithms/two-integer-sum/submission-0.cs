public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();  // value -> index

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (map.ContainsKey(complement)) {
                return new int[] { map[complement], i };
            }

            // store current number
            map[nums[i]] = i;
        }

        return new int[0];
    }
}
