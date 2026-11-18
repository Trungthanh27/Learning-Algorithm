# LeetCode Problems Using Binary Search

**Total: 21 problems** — 5 Easy, 13 Medium, 3 Hard

## 1. Classic Binary Search (Exact match & Insertion Point)

Best for finding targets or insertion boundaries in fully sorted 1D and 2D arrays.

| # | Problem | Difficulty |
|---|---------|-----------|
| 704 | [Binary Search](https://leetcode.com/problems/binary-search/) | Easy |
| 35 | [Search Insert Position](https://leetcode.com/problems/search-insert-position/) | Easy |
| 744 | [Find Smallest Letter Greater Than Target](https://leetcode.com/problems/find-smallest-letter-greater-than-target/) | Easy |
| 34 | [Find First and Last Position of Element in Sorted Array](https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/) | Medium |
| 74 | [Search a 2D Matrix](https://leetcode.com/problems/search-a-2d-matrix/) | Medium |
| 240 | [Search a 2D Matrix II](https://leetcode.com/problems/search-a-2d-matrix-ii/) | Medium |

## 2. Rotated & Mountain Arrays

Best for searching in partially sorted arrays with inflection points or peaks.

| # | Problem | Difficulty |
|---|---------|-----------|
| 33 | [Search in Rotated Sorted Array](https://leetcode.com/problems/search-in-rotated-sorted-array/) | Medium |
| 81 | [Search in Rotated Sorted Array II](https://leetcode.com/problems/search-in-rotated-sorted-array-ii/) | Medium |
| 153 | [Find Minimum in Rotated Sorted Array](https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/) | Medium |
| 162 | [Find Peak Element](https://leetcode.com/problems/find-peak-element/) | Medium |
| 852 | [Peak Index in a Mountain Array](https://leetcode.com/problems/peak-index-in-a-mountain-array/) | Medium |
| 154 | [Find Minimum in Rotated Sorted Array II](https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/) | Hard |

## 3. Binary Search on Answer (Feasibility / Predicate)

Best for optimization problems with monotonic feasibility checks across a range.

| # | Problem | Difficulty |
|---|---------|-----------|
| 69 | [Sqrt(x)](https://leetcode.com/problems/sqrtx/) | Easy |
| 278 | [First Bad Version](https://leetcode.com/problems/first-bad-version/) | Easy |
| 875 | [Koko Eating Bananas](https://leetcode.com/problems/koko-eating-bananas/) | Medium |
| 1011 | [Capacity To Ship Packages Within D Days](https://leetcode.com/problems/capacity-to-ship-packages-within-d-days/) | Medium |
| 1283 | [Find the Smallest Divisor Given a Threshold](https://leetcode.com/problems/find-the-smallest-divisor-given-a-threshold/) | Medium |
| 1482 | [Minimum Number of Days to Make m Bouquets](https://leetcode.com/problems/minimum-number-of-days-to-make-m-bouquets/) | Medium |
| 410 | [Split Array Largest Sum](https://leetcode.com/problems/split-array-largest-sum/) | Hard |

## 4. Two Pointers / Median Search

Best for partitioning two sorted arrays or finding k-closest elements.

| # | Problem | Difficulty |
|---|---------|-----------|
| 658 | [Find K Closest Elements](https://leetcode.com/problems/find-k-closest-elements/) | Medium |
| 4 | [Median of Two Sorted Arrays](https://leetcode.com/problems/median-of-two-sorted-arrays/) | Hard |

## Suggested Study Order

1. **Basics:** 704, 35, 278, 69
2. **Core:** 34, 33, 153, 162, 74, 875, 1011
3. **Advanced:** 410, 4

Tip: When asked for the 'minimum capacity' or 'maximum speed', think: if speed X works, does X+1 also work? If monotonic, binary search on the answer space `[low, high]`.
