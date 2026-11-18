# LeetCode Problems Using Bit Manipulation

**Total: 20 problems** — 7 Easy, 12 Medium, 1 Hard

## 1. Bitwise Arithmetic & Basics

Best for bit counting, power of two checks, bit reversals, and adder simulation.

| # | Problem | Difficulty |
|---|---------|-----------|
| 191 | [Number of 1 Bits](https://leetcode.com/problems/number-of-1-bits/) | Easy |
| 231 | [Power of Two](https://leetcode.com/problems/power-of-two/) | Easy |
| 338 | [Counting Bits](https://leetcode.com/problems/counting-bits/) | Easy |
| 190 | [Reverse Bits](https://leetcode.com/problems/reverse-bits/) | Easy |
| 371 | [Sum of Two Integers](https://leetcode.com/problems/sum-of-two-integers/) | Medium |
| 29 | [Divide Two Integers](https://leetcode.com/problems/divide-two-integers/) | Medium |

## 2. XOR Properties (Cancellation & Uniqueness)

Best for single-element isolation, missing numbers, and bitwise differences using x ^ x = 0.

| # | Problem | Difficulty |
|---|---------|-----------|
| 136 | [Single Number](https://leetcode.com/problems/single-number/) | Easy |
| 268 | [Missing Number](https://leetcode.com/problems/missing-number/) | Easy |
| 389 | [Find the Difference](https://leetcode.com/problems/find-the-difference/) | Easy |
| 137 | [Single Number II](https://leetcode.com/problems/single-number-ii/) | Medium |
| 260 | [Single Number III](https://leetcode.com/problems/single-number-iii/) | Medium |
| 2429 | [Minimize XOR](https://leetcode.com/problems/minimize-xor/) | Medium |

## 3. Bitmasking & Subsets

Best for power-set enumeration, state representations, and traveling-salesman transitions.

| # | Problem | Difficulty |
|---|---------|-----------|
| 78 | [Subsets](https://leetcode.com/problems/subsets/) | Medium |
| 187 | [Repeated DNA Sequences](https://leetcode.com/problems/repeated-dna-sequences/) | Medium |
| 89 | [Gray Code](https://leetcode.com/problems/gray-code/) | Medium |
| 779 | [K-th Symbol in Grammar](https://leetcode.com/problems/k-th-symbol-in-grammar/) | Medium |
| 847 | [Shortest Path Visiting All Nodes](https://leetcode.com/problems/shortest-path-visiting-all-nodes/) | Hard |

## 4. Bitwise Range & Optimization Tricks

Best for bitwise range AND, bit flipping, and XOR maximums via binary tries.

| # | Problem | Difficulty |
|---|---------|-----------|
| 201 | [Bitwise AND of Numbers Range](https://leetcode.com/problems/bitwise-and-of-numbers-range/) | Medium |
| 1318 | [Minimum Flips to Make a OR b Equal to c](https://leetcode.com/problems/minimum-flips-to-make-a-or-b-equal-to-c/) | Medium |
| 421 | [Maximum XOR of Two Numbers in an Array](https://leetcode.com/problems/maximum-xor-of-two-numbers-in-an-array/) | Medium |

## Suggested Study Order

1. **Basics:** 136, 191, 231, 338, 190
2. **Core:** 268, 260, 371, 78, 201, 1318
3. **Advanced:** 137, 847, 421

Tip: Memorize: `n & (n - 1)` removes the lowest set bit; `n & -n` isolates the lowest set bit; and `x ^ x = 0` eliminates duplicate pairs.
