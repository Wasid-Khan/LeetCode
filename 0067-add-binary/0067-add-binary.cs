public class Solution {
    public string AddBinary(string a, string b) {
        // Initialize result as an empty string.
        string res = "";

        // Defining two pointers to keep track of the bit we are working on.
        int i = a.Length - 1;
        int j = b.Length - 1;

        int sum, carry = 0;

        while (i >= 0 || j >= 0 || carry > 0) // Include carry in the loop condition to account for leftover carry
        {
            sum = carry;
            if (i >= 0) {
                sum += a[i] - '0'; // Convert character to integer by subtracting '0'
                i--;
            }
            if (j >= 0) {
                sum += b[j] - '0'; // Convert character to integer by subtracting '0'
                j--;
            }

            // Add the result of sum % 2 to the front of the result string.
            res = (sum % 2).ToString() + res; // Convert integer to string and prepend it to res
            carry = sum / 2; // Update carry
        }

        return res;
    }
}
