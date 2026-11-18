# LeetCode Problems Using Backtracking

**Total: 17 problems** — 0 Easy, 14 Medium, 3 Hard

## 1. Subsets & Combinations

Best for finding all possible power sets, combinations of size k, and target sum combinations.

| # | Problem | Difficulty |
|---|---------|-----------|
| 78 | [Subsets](https://leetcode.com/problems/subsets/) | Medium |
| 90 | [Subsets II](https://leetcode.com/problems/subsets-ii/) | Medium |
| 77 | [Combinations](https://leetcode.com/problems/combinations/) | Medium |
| 39 | [Combination Sum](https://leetcode.com/problems/combination-sum/) | Medium |
| 40 | [Combination Sum II](https://leetcode.com/problems/combination-sum-ii/) | Medium |
| 216 | [Combination Sum III](https://leetcode.com/problems/combination-sum-iii/) | Medium |

## 2. Permutations

Best for generating all distinct reorderings of an array or string.

| # | Problem | Difficulty |
|---|---------|-----------|
| 46 | [Permutations](https://leetcode.com/problems/permutations/) | Medium |
| 47 | [Permutations II](https://leetcode.com/problems/permutations-ii/) | Medium |
| 31 | [Next Permutation](https://leetcode.com/problems/next-permutation/) | Medium |

## 3. String Partitioning & Generation

Best for generating valid parentheses, splitting strings into palindromes, and IP reconstruction.

| # | Problem | Difficulty |
|---|---------|-----------|
| 17 | [Letter Combinations of a Phone Number](https://leetcode.com/problems/letter-combinations-of-a-phone-number/) | Medium |
| 22 | [Generate Parentheses](https://leetcode.com/problems/generate-parentheses/) | Medium |
| 93 | [Restore IP Addresses](https://leetcode.com/problems/restore-ip-addresses/) | Medium |
| 131 | [Palindrome Partitioning](https://leetcode.com/problems/palindrome-partitioning/) | Medium |

## 4. Grid Search & Constraint Solvers

Best for chess board placements, matrix word searches, and Sudoku solvers.

| # | Problem | Difficulty |
|---|---------|-----------|
| 79 | [Word Search](https://leetcode.com/problems/word-search/) | Medium |
| 51 | [N-Queens](https://leetcode.com/problems/n-queens/) | Hard |
| 52 | [N-Queens II](https://leetcode.com/problems/n-queens-ii/) | Hard |
| 37 | [Sudoku Solver](https://leetcode.com/problems/sudoku-solver/) | Hard |

## Suggested Study Order

1. **Basics:** 78, 77, 46, 17, 22
2. **Core:** 39, 40, 90, 47, 79, 131
3. **Advanced:** 51, 52, 37

Tip: When elements can have duplicates, sort the input first and skip adjacent duplicates with `if i > start and nums[i] == nums[i-1]: continue` to prevent duplicate branches.
