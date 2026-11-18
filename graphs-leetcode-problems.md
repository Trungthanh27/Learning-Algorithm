# LeetCode Problems Using Graphs

**Total: 22 problems** — 1 Easy, 19 Medium, 2 Hard

## 1. Matrix Traversal (Grid BFS & DFS)

Best for connected components, flood fill, and shortest paths on uniform 2D grids.

| # | Problem | Difficulty |
|---|---------|-----------|
| 733 | [Flood Fill](https://leetcode.com/problems/flood-fill/) | Easy |
| 200 | [Number of Islands](https://leetcode.com/problems/number-of-islands/) | Medium |
| 695 | [Max Area of Island](https://leetcode.com/problems/max-area-of-island/) | Medium |
| 130 | [Surrounded Regions](https://leetcode.com/problems/surrounded-regions/) | Medium |
| 994 | [Rotting Oranges](https://leetcode.com/problems/rotting-oranges/) | Medium |
| 417 | [Pacific Atlantic Water Flow](https://leetcode.com/problems/pacific-atlantic-water-flow/) | Medium |
| 1091 | [Shortest Path in Binary Matrix](https://leetcode.com/problems/shortest-path-in-binary-matrix/) | Medium |

## 2. Topological Sort (DAG Dependencies)

Best for dependency resolution, prerequisite checking, and detecting cycles in directed graphs.

| # | Problem | Difficulty |
|---|---------|-----------|
| 207 | [Course Schedule](https://leetcode.com/problems/course-schedule/) | Medium |
| 210 | [Course Schedule II](https://leetcode.com/problems/course-schedule-ii/) | Medium |
| 802 | [Find Eventual Safe States](https://leetcode.com/problems/find-eventual-safe-states/) | Medium |
| 310 | [Minimum Height Trees](https://leetcode.com/problems/minimum-height-trees/) | Medium |
| 269 | [Alien Dictionary](https://leetcode.com/problems/alien-dictionary/) | Hard |

## 3. Disjoint Set Union (Union-Find)

Best for dynamic connectivity, cycle detection in undirected graphs, and grouping components.

| # | Problem | Difficulty |
|---|---------|-----------|
| 547 | [Number of Provinces](https://leetcode.com/problems/number-of-provinces/) | Medium |
| 684 | [Redundant Connection](https://leetcode.com/problems/redundant-connection/) | Medium |
| 323 | [Number of Connected Components in an Undirected Graph](https://leetcode.com/problems/number-of-connected-components-in-an-undirected-graph/) | Medium |
| 721 | [Accounts Merge](https://leetcode.com/problems/accounts-merge/) | Medium |
| 1319 | [Number of Operations to Make Network Connected](https://leetcode.com/problems/number-of-operations-to-make-network-connected/) | Medium |

## 4. Shortest Paths & Weighted Graphs (Dijkstra)

Best for single-source shortest path on non-negative weighted graphs and step transformations.

| # | Problem | Difficulty |
|---|---------|-----------|
| 743 | [Network Delay Time](https://leetcode.com/problems/network-delay-time/) | Medium |
| 1631 | [Path With Minimum Effort](https://leetcode.com/problems/path-with-minimum-effort/) | Medium |
| 1514 | [Path with Maximum Probability](https://leetcode.com/problems/path-with-maximum-probability/) | Medium |
| 787 | [Cheapest Flights Within K Stops](https://leetcode.com/problems/cheapest-flights-within-k-stops/) | Medium |
| 127 | [Word Ladder](https://leetcode.com/problems/word-ladder/) | Hard |

## Suggested Study Order

1. **Basics:** 733, 200, 695, 547
2. **Core:** 994, 417, 207, 210, 684, 743, 1091
3. **Advanced:** 127, 269, 787

Tip: Use BFS for unweighted shortest paths, Dijkstra for non-negative weighted graphs, Topological Sort for DAG prerequisite order, and Union-Find for fast dynamic connectivity.
