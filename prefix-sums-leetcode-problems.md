# LeetCode Problems Using Prefix Sums

**Total: 16 problems** — 5 Easy, 10 Medium, 1 Hard

## 1. 1D Range Sum Queries & Pivot Points

Best for answering range sum queries in O(1) after O(n) preprocessing.

| # | Problem | Difficulty |
|---|---------|-----------|
| 1480 | [Running Sum of 1d Array](https://leetcode.com/problems/running-sum-of-1d-array/) | Easy |
| 303 | [Range Sum Query - Immutable](https://leetcode.com/problems/range-sum-query-immutable/) | Easy |
| 724 | [Find Pivot Index](https://leetcode.com/problems/find-pivot-index/) | Easy |
| 1991 | [Find the Middle Index in Array](https://leetcode.com/problems/find-the-middle-index-in-array/) | Easy |
| 238 | [Product of Array Except Self](https://leetcode.com/problems/product-of-array-except-self/) | Medium |

## 2. Hash Map + Prefix Sum (Target Subarrays)

Best for counting or locating subarrays that satisfy sum, parity, or remainder constraints.

| # | Problem | Difficulty |
|---|---------|-----------|
| 560 | [Subarray Sum Equals K](https://leetcode.com/problems/subarray-sum-equals-k/) | Medium |
| 525 | [Contiguous Array](https://leetcode.com/problems/contiguous-array/) | Medium |
| 974 | [Subarray Sums Divisible by K](https://leetcode.com/problems/subarray-sums-divisible-by-k/) | Medium |
| 523 | [Continuous Subarray Sum](https://leetcode.com/problems/continuous-subarray-sum/) | Medium |
| 1248 | [Count Number of Nice Subarrays](https://leetcode.com/problems/count-number-of-nice-subarrays/) | Medium |

## 3. 2D Prefix Sums (Matrix Range Queries)

Best for calculating rectangular submatrix sums in O(1) time using inclusion-exclusion.

| # | Problem | Difficulty |
|---|---------|-----------|
| 304 | [Range Sum Query 2D - Immutable](https://leetcode.com/problems/range-sum-query-2d-immutable/) | Medium |
| 1292 | [Maximum Side Length of a Square with Sum Less than or Equal to Threshold](https://leetcode.com/problems/maximum-side-length-of-a-square-with-sum-less-than-or-equal-to-threshold/) | Medium |
| 1074 | [Number of Submatrices That Sum to Target](https://leetcode.com/problems/number-of-submatrices-that-sum-to-target/) | Hard |

## 4. Difference Array (Range Updates / Sweep Line)

Best for applying batch increments to ranges `[L, R]` in O(1) and computing the final array in O(n).

| # | Problem | Difficulty |
|---|---------|-----------|
| 1854 | [Maximum Population Year](https://leetcode.com/problems/maximum-population-year/) | Easy |
| 1109 | [Corporate Flight Bookings](https://leetcode.com/problems/corporate-flight-bookings/) | Medium |
| 1094 | [Car Pooling](https://leetcode.com/problems/car-pooling/) | Medium |

## Suggested Study Order

1. **Basics:** 1480, 303, 724, 238
2. **Core:** 560, 525, 974, 304, 1094, 1109
3. **Advanced:** 523, 1074

Tip: To find subarrays where sum equals k, check if `prefix_sum - k` has been seen in your frequency map; initialize `prefix_map[0] = 1` to handle subarrays starting at index 0.
