public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numToIndex = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (numToIndex.ContainsKey(target - nums[i]))
            {
                return new[] {numToIndex[target-nums[i]], i};
            }
            numToIndex.Add(nums[i], i);
        }

        return null;
    }
}
