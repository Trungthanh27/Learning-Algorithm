# LeetCode Problems Using Fast and Slow Pointers

**Total: 16 problems** — 6 Easy, 10 Medium, 0 Hard

## 1. Cycle Detection (Floyd's Tortoise and Hare)

Best for finding loops in linked lists, state graphs, and arrays.

| # | Problem | Difficulty |
|---|---------|-----------|
| 141 | [Linked List Cycle](https://leetcode.com/problems/linked-list-cycle/) | Easy |
| 202 | [Happy Number](https://leetcode.com/problems/happy-number/) | Easy |
| 142 | [Linked List Cycle II](https://leetcode.com/problems/linked-list-cycle-ii/) | Medium |
| 287 | [Find the Duplicate Number](https://leetcode.com/problems/find-the-duplicate-number/) | Medium |
| 457 | [Circular Array Loop](https://leetcode.com/problems/circular-array-loop/) | Medium |

## 2. Middle Node & Palindrome Checks

Best for finding list midpoints in a single pass without knowing length upfront.

| # | Problem | Difficulty |
|---|---------|-----------|
| 876 | [Middle of the Linked List](https://leetcode.com/problems/middle-of-the-linked-list/) | Easy |
| 234 | [Palindrome Linked List](https://leetcode.com/problems/palindrome-linked-list/) | Easy |
| 143 | [Reorder List](https://leetcode.com/problems/reorder-list/) | Medium |
| 2095 | [Delete the Middle Node of a Linked List](https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/) | Medium |
| 2130 | [Maximum Twin Sum of a Linked List](https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/) | Medium |

## 3. Fixed-Gap / Offset Pointers

Best for one-pass search of elements at a fixed distance from the end.

| # | Problem | Difficulty |
|---|---------|-----------|
| 19 | [Remove Nth Node From End of List](https://leetcode.com/problems/remove-nth-node-from-end-of-list/) | Medium |
| 61 | [Rotate List](https://leetcode.com/problems/rotate-list/) | Medium |
| 1721 | [Swapping Nodes in a Linked List](https://leetcode.com/problems/swapping-nodes-in-a-linked-list/) | Medium |

## 4. Step Alignment & Two Runners

Best for aligning pointers with differing lengths or speeds.

| # | Problem | Difficulty |
|---|---------|-----------|
| 160 | [Intersection of Two Linked Lists](https://leetcode.com/problems/intersection-of-two-linked-lists/) | Easy |
| 392 | [Is Subsequence](https://leetcode.com/problems/is-subsequence/) | Easy |
| 189 | [Rotate Array](https://leetcode.com/problems/rotate-array/) | Medium |

## Suggested Study Order

1. **Basics:** 141, 876, 202, 234, 160, 392
2. **Core:** 142, 19, 61, 143, 189, 287, 1721, 2095, 2130
3. **Advanced:** 457

Tip: When slow moves 1 step and fast moves 2 steps, the moment they meet in a cycle, resetting slow to head and moving both 1 step will find the exact cycle entry.
