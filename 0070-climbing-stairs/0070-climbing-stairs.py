class Solution:
    def climbStairs(self, n: int) -> int:
        # Dictionary to store results of subproblems (Memoization)
        memo = {}

        def countWays(p):
            # Base cases: if there's 1 step, there's 1 way; if 2 steps, 2 ways
            if p == 1:
                return 1
            if p == 2:
                return 2

            # Check if result for `p` is already computed
            if p in memo:
                return memo[p]

            # Recursive calls for (p-1) and (p-2)
            recCall1 = countWays(p - 1)
            recCall2 = countWays(p - 2)

            # Compute and store the result in the memo dictionary
            memo[p] = recCall1 + recCall2
            return memo[p]

        # Start the helper function with the given number of steps
        return countWays(n)
