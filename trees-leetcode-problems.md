# LeetCode Problems Using Trees

**Total: 23 problems** — 8 Easy, 13 Medium, 2 Hard

## 1. DFS & Tree Properties (Depth, Invert, Symmetry)

Best for computing tree height, checking symmetry, and validating path sums recursively.

| # | Problem | Difficulty |
|---|---------|-----------|
| 104 | [Maximum Depth of Binary Tree](https://leetcode.com/problems/maximum-depth-of-binary-tree/) | Easy |
| 226 | [Invert Binary Tree](https://leetcode.com/problems/invert-binary-tree/) | Easy |
| 100 | [Same Tree](https://leetcode.com/problems/same-tree/) | Easy |
| 101 | [Symmetric Tree](https://leetcode.com/problems/symmetric-tree/) | Easy |
| 110 | [Balanced Binary Tree](https://leetcode.com/problems/balanced-binary-tree/) | Easy |
| 112 | [Path Sum](https://leetcode.com/problems/path-sum/) | Easy |
| 543 | [Diameter of Binary Tree](https://leetcode.com/problems/diameter-of-binary-tree/) | Easy |
| 124 | [Binary Tree Maximum Path Sum](https://leetcode.com/problems/binary-tree-maximum-path-sum/) | Hard |

## 2. BFS / Level-Order Traversal

Best for layer-by-layer exploration, right-side views, and zigzag orders.

| # | Problem | Difficulty |
|---|---------|-----------|
| 102 | [Binary Tree Level Order Traversal](https://leetcode.com/problems/binary-tree-level-order-traversal/) | Medium |
| 103 | [Binary Tree Zigzag Level Order Traversal](https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/) | Medium |
| 199 | [Binary Tree Right Side View](https://leetcode.com/problems/binary-tree-right-side-view/) | Medium |
| 116 | [Populating Next Right Pointers in Each Node](https://leetcode.com/problems/populating-next-right-pointers-in-each-node/) | Medium |
| 515 | [Find Largest Value in Each Tree Row](https://leetcode.com/problems/find-largest-value-in-each-tree-row/) | Medium |

## 3. Binary Search Tree (BST) Operations

Best for leveraging the in-order sorted property for searching, insertion, and validation.

| # | Problem | Difficulty |
|---|---------|-----------|
| 700 | [Search in a Binary Search Tree](https://leetcode.com/problems/search-in-a-binary-search-tree/) | Easy |
| 701 | [Insert into a Binary Search Tree](https://leetcode.com/problems/insert-into-a-binary-search-tree/) | Medium |
| 98 | [Validate Binary Search Tree](https://leetcode.com/problems/validate-binary-search-tree/) | Medium |
| 230 | [Kth Smallest Element in a BST](https://leetcode.com/problems/kth-smallest-element-in-a-bst/) | Medium |
| 235 | [Lowest Common Ancestor of a Binary Search Tree](https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/) | Medium |
| 450 | [Delete Node in a BST](https://leetcode.com/problems/delete-node-in-a-bst/) | Medium |

## 4. Common Ancestor & Tree Reconstruction

Best for finding lowest common ancestors and serializing/deserializing tree structures.

| # | Problem | Difficulty |
|---|---------|-----------|
| 236 | [Lowest Common Ancestor of a Binary Tree](https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/) | Medium |
| 105 | [Construct Binary Tree from Preorder and Inorder Traversal](https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/) | Medium |
| 106 | [Construct Binary Tree from Inorder and Postorder Traversal](https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/) | Medium |
| 297 | [Serialize and Deserialize Binary Tree](https://leetcode.com/problems/serialize-and-deserialize-binary-tree/) | Hard |

## Suggested Study Order

1. **Basics:** 104, 226, 100, 101, 112, 700
2. **Core:** 102, 199, 98, 235, 236, 105, 543, 230
3. **Advanced:** 124, 297

Tip: An in-order traversal of a BST visits nodes in strictly increasing order. For recursive DFS, clearly separate what a node returns to its parent versus what it updates globally.
