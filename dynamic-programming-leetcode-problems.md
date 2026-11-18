# LeetCode Problems Using Dynamic Programming

**Total: 26 problems** — 3 Easy, 21 Medium, 2 Hard

## 1. 1D DP (Linear States & Fibonacci-style)

Best for step transitions, house robbing, word breaking, and coin change combinations.

| # | Problem | Difficulty |
|---|---------|-----------|
| 70 | [Climbing Stairs](https://leetcode.com/problems/climbing-stairs/) | Easy |
| 746 | [Min Cost Climbing Stairs](https://leetcode.com/problems/min-cost-climbing-stairs/) | Easy |
| 198 | [House Robber](https://leetcode.com/problems/house-robber/) | Medium |
| 213 | [House Robber II](https://leetcode.com/problems/house-robber-ii/) | Medium |
| 91 | [Decode Ways](https://leetcode.com/problems/decode-ways/) | Medium |
| 139 | [Word Break](https://leetcode.com/problems/word-break/) | Medium |
| 300 | [Longest Increasing Subsequence](https://leetcode.com/problems/longest-increasing-subsequence/) | Medium |
| 322 | [Coin Change](https://leetcode.com/problems/coin-change/) | Medium |
| 518 | [Coin Change II](https://leetcode.com/problems/coin-change-ii/) | Medium |

## 2. 2D DP (Grids & Paths)

Best for shortest or unique paths on 2D matrices and maximal squares.

| # | Problem | Difficulty |
|---|---------|-----------|
| 62 | [Unique Paths](https://leetcode.com/problems/unique-paths/) | Medium |
| 63 | [Unique Paths II](https://leetcode.com/problems/unique-paths-ii/) | Medium |
| 64 | [Minimum Path Sum](https://leetcode.com/problems/minimum-path-sum/) | Medium |
| 120 | [Triangle](https://leetcode.com/problems/triangle/) | Medium |
| 221 | [Maximal Square](https://leetcode.com/problems/maximal-square/) | Medium |

## 3. Strings & Subsequences (LCS, Palindromes, Edit Distance)

Best for string alignment, transformations, and palindromic subsequences.

| # | Problem | Difficulty |
|---|---------|-----------|
| 5 | [Longest Palindromic Substring](https://leetcode.com/problems/longest-palindromic-substring/) | Medium |
| 516 | [Longest Palindromic Subsequence](https://leetcode.com/problems/longest-palindromic-subsequence/) | Medium |
| 1143 | [Longest Common Subsequence](https://leetcode.com/problems/longest-common-subsequence/) | Medium |
| 72 | [Edit Distance](https://leetcode.com/problems/edit-distance/) | Medium |
| 10 | [Regular Expression Matching](https://leetcode.com/problems/regular-expression-matching/) | Hard |
| 44 | [Wildcard Matching](https://leetcode.com/problems/wildcard-matching/) | Hard |

## 4. Knapsack Variants & State Machines

Best for subset sum partitioning and multi-state stock trading transitions.

| # | Problem | Difficulty |
|---|---------|-----------|
| 121 | [Best Time to Buy and Sell Stock](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/) | Easy |
| 122 | [Best Time to Buy and Sell Stock II](https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/) | Medium |
| 309 | [Best Time to Buy and Sell Stock with Cooldown](https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/) | Medium |
| 714 | [Best Time to Buy and Sell Stock with Transaction Fee](https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee/) | Medium |
| 416 | [Partition Equal Subset Sum](https://leetcode.com/problems/partition-equal-subset-sum/) | Medium |
| 494 | [Target Sum](https://leetcode.com/problems/target-sum/) | Medium |

## Suggested Study Order

1. **Basics:** 70, 746, 121, 198, 62
2. **Core:** 213, 300, 322, 1143, 416, 139, 5
3. **Advanced:** 72, 309, 10, 44

Tip: Start by identifying the subproblem state: write out the recurrence relation `dp[i]` or `dp[i][j]` on paper before coding the loop.
