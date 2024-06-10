class Solution {
    public int heightChecker(int[] heights) {
        if(heights == null || heights.length==0)
            return 0;

        int[] expected = Arrays.copyOf(heights, heights.length);
        Arrays.sort(expected);

        int n = heights.length, count=0;

        for(int i=0; i<n; i++)
        {
            if(heights[i] != expected[i])
                count++;
        }

        return count;
    }
}