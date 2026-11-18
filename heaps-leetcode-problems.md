# LeetCode Problems Using Heaps (Priority Queues)

**Total: 17 problems** — 2 Easy, 10 Medium, 5 Hard

## 1. Top K Elements (Min-Heap / Max-Heap)

Best for tracking k highest or lowest elements without sorting the entire array.

| # | Problem | Difficulty |
|---|---------|-----------|
| 703 | [Kth Largest Element in a Stream](https://leetcode.com/problems/kth-largest-element-in-a-stream/) | Easy |
| 1046 | [Last Stone Weight](https://leetcode.com/problems/last-stone-weight/) | Easy |
| 215 | [Kth Largest Element in an Array](https://leetcode.com/problems/kth-largest-element-in-an-array/) | Medium |
| 347 | [Top K Frequent Elements](https://leetcode.com/problems/top-k-frequent-elements/) | Medium |
| 451 | [Sort Characters By Frequency](https://leetcode.com/problems/sort-characters-by-frequency/) | Medium |
| 973 | [K Closest Points to Origin](https://leetcode.com/problems/k-closest-points-to-origin/) | Medium |

## 2. Two Heaps (Dynamic Median & Partitioning)

Best for maintaining dynamic balance between lower and upper halves of data streams.

| # | Problem | Difficulty |
|---|---------|-----------|
| 295 | [Find Median from Data Stream](https://leetcode.com/problems/find-median-from-data-stream/) | Hard |
| 480 | [Sliding Window Median](https://leetcode.com/problems/sliding-window-median/) | Hard |

## 3. Merging K Sorted Streams

Best for multi-way merge across sorted linked lists, arrays, or matrix rows.

| # | Problem | Difficulty |
|---|---------|-----------|
| 378 | [Kth Smallest Element in a Sorted Matrix](https://leetcode.com/problems/kth-smallest-element-in-a-sorted-matrix/) | Medium |
| 373 | [Find K Pairs with Smallest Sums](https://leetcode.com/problems/find-k-pairs-with-smallest-sums/) | Medium |
| 23 | [Merge k Sorted Lists](https://leetcode.com/problems/merge-k-sorted-lists/) | Hard |

## 4. Greedy Scheduling & Event Simulation

Best for task scheduling, interval overlaps, and resource allocation under constraints.

| # | Problem | Difficulty |
|---|---------|-----------|
| 253 | [Meeting Rooms II](https://leetcode.com/problems/meeting-rooms-ii/) | Medium |
| 621 | [Task Scheduler](https://leetcode.com/problems/task-scheduler/) | Medium |
| 767 | [Reorganize String](https://leetcode.com/problems/reorganize-string/) | Medium |
| 1834 | [Single-Threaded CPU](https://leetcode.com/problems/single-threaded-cpu/) | Medium |
| 502 | [IPO](https://leetcode.com/problems/ipo/) | Hard |
| 857 | [Minimum Cost to Hire K Workers](https://leetcode.com/problems/minimum-cost-to-hire-k-workers/) | Hard |

## Suggested Study Order

1. **Basics:** 703, 1046, 215
2. **Core:** 347, 973, 621, 767, 378
3. **Advanced:** 23, 253, 295, 480, 502, 857

Tip: To find the K largest items, maintain a Min-Heap of size K (so smaller items get evicted); to find the K smallest items, use a Max-Heap of size K.
