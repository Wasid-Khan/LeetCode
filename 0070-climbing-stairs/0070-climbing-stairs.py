class Solution:
    def climbStairs(self, n: int) -> int:
        # Use a dictionary to store computed results for each step
        memo = {}

        def helper(steps):
            # If steps are 0 or 1, there's only one way to climb
            if steps == 0:
                return 1
            if steps == 1:
                return 1

            # If result is already computed, return it (Memoization)
            if steps in memo:
                return memo[steps]

            # Compute the number of ways for the current step
            # Recursive calls for (n-1) and (n-2)
            left = helper(steps - 1)
            right = helper(steps - 2)
            memo[steps] = left + right  # Store the result in memo

            return memo[steps]

        # Start the helper function with input `n`
        return helper(n)
