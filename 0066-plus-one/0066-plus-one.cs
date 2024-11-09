public class Solution {
    public int[] PlusOne(int[] digits) {
        int n = digits.Length-1;

        while(n >= 0)
        {
            if(digits[n] < 9)
            {
                digits[n]++;
                return digits;
            }
            digits[n--] = 0;
        }

        digits = new int [digits.Length+1];
        digits[0]=1;
        return digits;
    }
}