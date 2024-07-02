public class Solution {
   public int[] Intersect(int[] nums1, int[] nums2)
    {
        List<int> common = new List<int>();
        Dictionary<int, int> counts = new Dictionary<int, int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            counts[nums1[i]] = counts.GetValueOrDefault(nums1[i]) + 1;
        }
        
        for (int i = 0; i < nums2.Length; i++)
        {
            if (counts.GetValueOrDefault(nums2[i]) > 0)
            {
                common.Add(nums2[i]);
                counts[nums2[i]] = counts.GetValueOrDefault(nums2[i]) - 1;
                if (counts[nums2[i]] == 0)
                {
                    counts.Remove(nums2[i]);
                }
            }
        }
        
        return common.ToArray();
    }
}