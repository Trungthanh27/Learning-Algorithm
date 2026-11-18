# LeetCode Problems Using Intervals

**Total: 13 problems** — 1 Easy, 10 Medium, 2 Hard

## 1. Merging & Inserting Intervals

Best for combining overlapping ranges and inserting new intervals into sorted sets.

| # | Problem | Difficulty |
|---|---------|-----------|
| 56 | [Merge Intervals](https://leetcode.com/problems/merge-intervals/) | Medium |
| 57 | [Insert Interval](https://leetcode.com/problems/insert-interval/) | Medium |
| 986 | [Interval List Intersections](https://leetcode.com/problems/interval-list-intersections/) | Medium |

## 2. Overlap & Conflict Detection

Best for finding collisions, removing minimum overlapping intervals, and greedy arrow bursts.

| # | Problem | Difficulty |
|---|---------|-----------|
| 252 | [Meeting Rooms](https://leetcode.com/problems/meeting-rooms/) | Easy |
| 435 | [Non-overlapping Intervals](https://leetcode.com/problems/non-overlapping-intervals/) | Medium |
| 452 | [Minimum Number of Arrows to Burst Balloons](https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons/) | Medium |

## 3. Room Allocation & Sweep-Line

Best for counting peak concurrent intervals using heaps or coordinate timeline sweeps.

| # | Problem | Difficulty |
|---|---------|-----------|
| 253 | [Meeting Rooms II](https://leetcode.com/problems/meeting-rooms-ii/) | Medium |
| 1094 | [Car Pooling](https://leetcode.com/problems/car-pooling/) | Medium |
| 1229 | [Meeting Scheduler](https://leetcode.com/problems/meeting-scheduler/) | Medium |
| 2406 | [Divide Intervals Into Minimum Number of Groups](https://leetcode.com/problems/divide-intervals-into-minimum-number-of-groups/) | Medium |

## 4. Advanced Interval Scheduling & Queries

Best for removing intervals, point covering queries, and multi-user free-time gaps.

| # | Problem | Difficulty |
|---|---------|-----------|
| 1272 | [Remove Interval](https://leetcode.com/problems/remove-interval/) | Medium |
| 759 | [Employee Free Time](https://leetcode.com/problems/employee-free-time/) | Hard |
| 1851 | [Minimum Interval to Include Each Query](https://leetcode.com/problems/minimum-interval-to-include-each-query/) | Hard |

## Suggested Study Order

1. **Basics:** 252, 56, 57
2. **Core:** 435, 452, 986, 253, 1094
3. **Advanced:** 759, 1851

Tip: Sort intervals by start time for merging and resource allocation; sort by end time when greedily selecting the maximum number of non-overlapping intervals.
