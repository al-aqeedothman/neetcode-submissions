public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> check = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
             if (check.Contains(nums[i])) return true;
             check.Add(nums[i]);
        }
        return false;
    }
}