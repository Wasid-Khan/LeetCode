public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //using C#
        int [] indices = new int[2];
        for(int i=0; i<nums.Length; i++)
        {
            for(int j=i+1; j<nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                 indices[0] = i;
                 indices[1] = j;
                }
            }
        }
        
        return indices;
    }
}