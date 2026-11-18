# LeetCode Problems Using Sort and Search

**Total: 20 problems** — 5 Easy, 13 Medium, 2 Hard

## 1. Sorting Algorithms & Custom Comparators

Best for array merging, custom string sorting, three-way partitioning, and linked list sorting.

| # | Problem | Difficulty |
|---|---------|-----------|
| 88 | [Merge Sorted Array](https://leetcode.com/problems/merge-sorted-array/) | Easy |
| 75 | [Sort Colors](https://leetcode.com/problems/sort-colors/) | Medium |
| 179 | [Largest Number](https://leetcode.com/problems/largest-number/) | Medium |
| 148 | [Sort List](https://leetcode.com/problems/sort-list/) | Medium |
| 912 | [Sort an Array](https://leetcode.com/problems/sort-an-array/) | Medium |
| 56 | [Merge Intervals](https://leetcode.com/problems/merge-intervals/) | Medium |

## 2. Binary Search in Sorted Structures

Best for finding targets, boundaries, and peak values in sorted or rotated arrays.

| # | Problem | Difficulty |
|---|---------|-----------|
| 704 | [Binary Search](https://leetcode.com/problems/binary-search/) | Easy |
| 35 | [Search Insert Position](https://leetcode.com/problems/search-insert-position/) | Easy |
| 33 | [Search in Rotated Sorted Array](https://leetcode.com/problems/search-in-rotated-sorted-array/) | Medium |
| 153 | [Find Minimum in Rotated Sorted Array](https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/) | Medium |
| 74 | [Search a 2D Matrix](https://leetcode.com/problems/search-a-2d-matrix/) | Medium |

## 3. Quickselect & Order Statistics

Best for finding the kth smallest/largest elements in O(n) average time without full sorting.

| # | Problem | Difficulty |
|---|---------|-----------|
| 215 | [Kth Largest Element in an Array](https://leetcode.com/problems/kth-largest-element-in-an-array/) | Medium |
| 347 | [Top K Frequent Elements](https://leetcode.com/problems/top-k-frequent-elements/) | Medium |
| 973 | [K Closest Points to Origin](https://leetcode.com/problems/k-closest-points-to-origin/) | Medium |
| 4 | [Median of Two Sorted Arrays](https://leetcode.com/problems/median-of-two-sorted-arrays/) | Hard |

## 4. Cyclic Sort (Missing / Duplicate Numbers in 1..n)

Best for finding missing, duplicated, or corrupted values in arrays of range `[1, n]` in O(n) time and O(1) space.

| # | Problem | Difficulty |
|---|---------|-----------|
| 268 | [Missing Number](https://leetcode.com/problems/missing-number/) | Easy |
| 448 | [Find All Numbers Disappeared in an Array](https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/) | Easy |
| 287 | [Find the Duplicate Number](https://leetcode.com/problems/find-the-duplicate-number/) | Medium |
| 442 | [Find All Duplicates in an Array](https://leetcode.com/problems/find-all-duplicates-in-an-array/) | Medium |
| 41 | [First Missing Positive](https://leetcode.com/problems/first-missing-positive/) | Hard |

## Suggested Study Order

1. **Basics:** 88, 704, 35, 268
2. **Core:** 75, 179, 33, 153, 215, 287, 448
3. **Advanced:** 41, 4

Tip: When elements are bounded in the range `[1, n]`, swap each element to its target index `nums[i] - 1` (Cyclic Sort) to achieve O(n) time and O(1) auxiliary space.
