# LeetCode Problems Using Tries (Prefix Trees)

**Total: 12 problems** — 1 Easy, 7 Medium, 4 Hard

## 1. Trie Implementation & Prefix Matching

Best for dictionary lookup, autocomplete prefix verification, and word insertion.

| # | Problem | Difficulty |
|---|---------|-----------|
| 14 | [Longest Common Prefix](https://leetcode.com/problems/longest-common-prefix/) | Easy |
| 208 | [Implement Trie (Prefix Tree)](https://leetcode.com/problems/implement-trie-prefix-tree/) | Medium |
| 211 | [Design Add and Search Words Data Structure](https://leetcode.com/problems/design-add-and-search-words-data-structure/) | Medium |
| 648 | [Replace Words](https://leetcode.com/problems/replace-words/) | Medium |
| 677 | [Map Sum Pairs](https://leetcode.com/problems/map-sum-pairs/) | Medium |

## 2. Word Search on 2D Boards

Best for multi-word search on character matrices with branch pruning.

| # | Problem | Difficulty |
|---|---------|-----------|
| 79 | [Word Search](https://leetcode.com/problems/word-search/) | Medium |
| 1268 | [Search Suggestions System](https://leetcode.com/problems/search-suggestions-system/) | Medium |
| 212 | [Word Search II](https://leetcode.com/problems/word-search-ii/) | Hard |

## 3. Bitwise XOR / Binary Trie

Best for finding the maximum XOR pair in an array in O(32 * n) time.

| # | Problem | Difficulty |
|---|---------|-----------|
| 421 | [Maximum XOR of Two Numbers in an Array](https://leetcode.com/problems/maximum-xor-of-two-numbers-in-an-array/) | Medium |
| 1707 | [Maximum XOR With an Element From Array](https://leetcode.com/problems/maximum-xor-with-an-element-from-array/) | Hard |

## 4. Stream Processing & Palindrome Suffixes

Best for character stream matching and palindrome concatenation detection.

| # | Problem | Difficulty |
|---|---------|-----------|
| 1032 | [Stream of Characters](https://leetcode.com/problems/stream-of-characters/) | Hard |
| 336 | [Palindrome Pairs](https://leetcode.com/problems/palindrome-pairs/) | Hard |

## Suggested Study Order

1. **Basics:** 14, 208
2. **Core:** 79, 211, 648, 677, 1268, 421
3. **Advanced:** 212, 1032, 1707, 336

Tip: When searching for multiple words in a 2D grid, loading the words into a Trie lets you prune dead branches immediately in your DFS rather than searching for each word separately.
