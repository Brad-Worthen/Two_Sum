public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int,int> dictionary = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (dictionary.ContainsKey(complement))
            {
                return new int[] {i, dictionary[complement]};
            }
            else
            {
                dictionary.Add(nums[i], i);
            }
        }

        return null;
    }
}
