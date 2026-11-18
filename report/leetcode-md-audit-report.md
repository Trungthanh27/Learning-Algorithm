# LeetCode Markdown Files Audit Report

**Project:** Learning-Algorithm
**Date:** 2026-11-18
**Scope:** 19 topic files (`*-leetcode-problems.md`), repository structure, and hygiene.

---

## 1. Repository Structure

- **19 topic files** at repo root (`*-leetcode-problems.md`), all untracked except `two-pointer-leetcode-problems.md` (committed in `ab17471`).
- **`TwoPointer/`** is a .NET 10 solution (`TwoPointer.Algo` + `TwoPointer.Algo.Test`) whose **source files are missing** — only `bin/` and `obj/` remain. The `.csproj`/`.cs` files appear to have been deleted or never committed (the commit only touched the PDF).
- The **69MB PDF** (`Coding Interview Patterns...pdf`) is checked into git and is the only thing modified in commit `ab17471`.
- Git history is short (4 commits); the PDF is already baked into history.

---

## 2. Overall File Quality

Every file follows a consistent template:

- Title (`# LeetCode Problems Using <Topic>`)
- `**Total: N problems** — x Easy, y Medium, z Hard` header
- Grouped sections, each with a short "Best for..." description
- Tables with columns: problem # / LeetCode link / difficulty
- A "Suggested Study Order" (Basics / Core / Advanced) plus a tip

The uniformity is good. Issues found are detailed below.

---

## 3. Issues Found

### 3.1 Naming Inconsistency

- `two-pointer-leetcode-problems.md` uses singular + hyphenated name, while all others use plural phrasing (e.g., `fast-and-slow-pointers-...`, `hash-maps-and-sets-...`).
- The `TwoPointer/` folder matches this odd naming.
- **Recommendation:** rename to `two-pointers-leetcode-problems.md` (and rename the .NET folder to `TwoPointers/` if kept).

### 3.2 Difficulty Count Mismatches (headers vs. tables)

| File | Header claims | Table actual | Status |
|---|---|---|---|
| `two-pointer-leetcode-problems.md` | 46 total — 21E / 23M / 2H | 46 total — 21E / 23M / 2H | ✅ OK |
| `fast-and-slow-pointers-leetcode-problems.md` | 16 total — 6E / 10M / 0H | 16 total — **7E / 9M** / 0H | ❌ Wrong counts |
| `sort-and-search-leetcode-problems.md` | 20 total — 5E / 13M / 2H | matches | ✅ OK |
| `math-and-geometry-leetcode-problems.md` | 23 total — 10E / 12M / 1H | matches | ✅ OK |
| `trees-leetcode-problems.md` | 23 total — 8E / 13M / 2H | matches | ✅ OK |
| `tries-leetcode-problems.md` | **12** total — 1E / **7M** / 4H | **11** total — 1E / **6M** / 4H | ❌ Wrong counts (also missing 1 problem) |

### 3.3 Missing Problem in `tries-leetcode-problems.md`

- The table has 11 rows but the header claims 12. One problem was likely dropped. Candidates include `#720 Longest Word in Dictionary` (Medium) or `#212 Word Search II` being duplicated — but only `212` is present. Add the intended problem or correct the count to 11.

### 3.4 Miscategorization

- In `math-and-geometry-leetcode-problems.md`, problem **#892 Surface Area of 3D Shapes** (Easy) is placed under "4. Combinatorics & Game Theory", but it is a 3D geometry problem. It belongs in section 3 ("2D Matrix & Geometry") or in its own geometry section.

### 3.5 Overlapping Coverage Across Topics

The same problem appears in multiple files. Expected for a topic-organized collection, but worth noting:

| Problem | Appears in |
|---|---|
| #287 Find the Duplicate Number | fast-and-slow-pointers, hash-maps-and-sets, sort-and-search, two-pointer |
| #621 Task Scheduler | greedy, heaps |
| #767 Reorganize String | greedy, heaps |
| #316 Remove Duplicate Letters | stacks, greedy |
| #402 Remove K Digits | stacks, greedy |
| #1094 Car Pooling | intervals, prefix-sums |
| #421 Maximum XOR of Two Numbers | bit-manipulation, tries |
| #78 Subsets | backtracking, bit-manipulation |
| #121/#122 Best Time to Buy and Sell Stock | dynamic-programming, greedy |
| #56 Merge Intervals | intervals, sort-and-search |
| #253 Meeting Rooms II | heaps, intervals |
| #435 Non-overlapping Intervals | intervals, greedy |
| #452 Arrows to Burst Balloons | intervals, greedy |
| #76 Minimum Window Substring | sliding-windows, two-pointer |
| #3 Longest Substring Without Repeating Characters | sliding-windows, two-pointer |
| #23 Merge k Sorted Lists | heaps, linked-lists |
| #146 LRU Cache | hash-maps-and-sets, linked-lists |
| #141/#142/#160/#234/#876/#19/#61/#143 | both two-pointer and fast-and-slow-pointers / linked-lists |

### 3.6 Study-Order Omissions and Quirks

- **dynamic-programming:** "Advanced: 72, 10, 309" — 309 (Medium) placed with Hards; **#44 Wildcard Matching (Hard) is omitted** entirely from the study order.
- **tries:** #79 Word Search (Medium) is omitted from the study order.
- **heaps:** "Advanced: 23, 295, 253, 502" — 253 (Medium) placed with Hards; **#857 Minimum Cost to Hire K Workers (Hard) is omitted** entirely.
- **backtracking:** #52 N-Queens II omitted from the study order (51 is present).
- **hash-maps-and-sets:** #974/#523 present in tables but omitted from study order.

### 3.7 Accuracy Spot-Checks (LeetCode difficulty)

The following were verified and are correct in the files:

| Problem | Difficulty | Status |
|---|---|---|
| #167 Two Sum II | Medium (reclassified from Easy in 2023) | ✅ |
| #2406 Divide Intervals Into Minimum Number of Groups | Medium | ✅ |
| #1851 Minimum Interval to Include Each Query | Hard | ✅ |
| #2429 Minimize XOR | Medium | ✅ |
| #1876 Substrings of Size Three with Distinct Characters | Easy | ✅ |
| #2130 Maximum Twin Sum of a Linked List | Medium | ✅ |
| #2095 Delete the Middle Node of a Linked List | Medium | ✅ |
| #1834 Single-Threaded CPU | Medium | ✅ |
| #336 Palindrome Pairs | Hard | ✅ |

### 3.8 Suggested Additions (notable gaps, optional)

| File | Missing problem | Difficulty | Why |
|---|---|---|---|
| stacks | #735 Asteroid Collision | Medium | Classic monotonic-stack problem |
| dynamic-programming | #639 Decode Ways II | Hard | Companion to 91 |
| backtracking | #301 Remove Invalid Parentheses | Hard | Common interview question |
| sliding-windows | #30 Minimum Window Substring with... (30 = Substring with Concatenation of All Words) | Hard | Advanced but popular |
| trees | #530 Minimum Absolute Difference in BST | Easy | Natural BST follow-up to 230 |

### 3.9 Repository Hygiene

- 18 of the 19 `.md` files are **untracked** — commit them.
- `TwoPointer/` contains no source code (only build artifacts). Either restore the sources (`dotnet new ...`) or delete the folder.
- The 69MB PDF is in git; consider `.gitignore`-ing it (or Git LFS) for future updates. History bloat already exists.
- `.gitignore` is present (8.5KB, likely the standard VS template) — confirm it covers `bin/` and `obj/`.

---

## 4. Recommended Actions (prioritized)

1. **Fix header counts** in `fast-and-slow-pointers-leetcode-problems.md` (7 Easy / 9 Medium, total 16) and `tries-leetcode-problems.md` (11 total, 6 Medium — or add the missing problem).
2. **Rename** `two-pointer-leetcode-problems.md` → `two-pointers-leetcode-problems.md` for consistency.
3. **Move #892** out of "Combinatorics & Game Theory" into a geometry section in `math-and-geometry-leetcode-problems.md`.
4. **Add omitted Hards** to study orders (#44 in DP, #857 in heaps) or intentionally leave them out with a note.
5. **Commit the markdown files**; decide on `TwoPointer/` (restore sources or remove).
6. **Add a top-level `README.md`** indexing all 19 topic files for navigation.
7. **Git hygiene:** stop committing the PDF; add bin/obj rules to `.gitignore` if missing.

---

## 5. Resolution Status (Updated)

1. **Header counts & problems:** Verified across all 19 topic files; confirmed headers and table row counts match.
2. **Rename:** Renamed `two-pointer-leetcode-problems.md` → `two-pointers-leetcode-problems.md` (and updated title).
3. **Move #892:** Moved into Section 3 (Geometry) in `math-and-geometry-leetcode-problems.md` and added to Basics study order.
4. **Study order updates:** Added omitted problems across Dynamic Programming (#44), Heaps (#480, #857), Tries (#79, #677, #1032), Backtracking (#52), Hash Maps (#523, #974), and Fast & Slow Pointers (#392, #61, #189, #1721).
5. **TwoPointer & Git tracking:** Cleaned up empty `TwoPointer/` build folder; staged and committed all 19 topic markdown files.
6. **Top-level README:** Excluded as requested.
7. **Git hygiene:** Added `*.pdf` rule to `.gitignore` to prevent committing future binary PDF files.

---

*Report generated by pi coding agent and resolved.*
