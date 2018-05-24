# C# Algorithms and Data Structures

[![Build Status](https://travis-ci.org/trekhleb/javascript-algorithms.svg?branch=master)](https://travis-ci.org/trekhleb/javascript-algorithms)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)

This repository is based on the [javascript-algorithms repository](https://github.com/trekhleb/javascript-algorithms), and contains C# based examples of many 
popular algorithms and data structures.

Each algorithm and data structure have its own separate README 
with related explanations and links for further reading and YouTube
videos.

## Data Structures

Data structure is a particular way of organizing and storing data in a computer so that it can 
be accessed and modified efficiently. More precisely, a data structure is a collection of data 
values, the relationships among them, and the functions or operations that can be applied to 
the data.

* [Linked List](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.DataStructures/linked-list)
* [Queue](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.DataStructures/queue)
* [Stack](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.DataStructures/stack)
* [Hash Table](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.DataStructures/hash-table)
* [Heap](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.DataStructures/heap)
* [Priority Queue](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.DataStructures/priority-queue)
* [Trie](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.DataStructures/trie)
* [Tree](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.DataStructures/tree)
    * [Binary Search Tree](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.DataStructures/tree/binary-search-tree)
    * [AVL Tree](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.DataStructures/tree/avl-tree)
    * Red-Black Tree
    * Suffix Tree
    * Segment Tree or Interval Tree
    * Binary Indexed Tree or Fenwick Tree
* [Graph](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.DataStructures/graph) (both directed and undirected)
* [Disjoint Set](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.DataStructures/disjoint-set)

## Algorithms

Algorithm is an unambiguous specification of how to solve a class of problems. Algorithm is
a set of rules that precisely defines a sequence of operations.

### Algorithms by Topic

* **Math**
  * [Factorial](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/math/factorial)
  * [Fibonacci Number](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/math/fibonacci)
  * [Primality Test](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/math/primality-test) (trial division method)
  * [Euclidean Algorithm](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/math/euclidean-algorithm) - calculate the Greatest Common Divisor (GCD)
  * [Least Common Multiple](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/math/least-common-multiple) (LCM)
  * [Integer Partition](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/math/integer-partition)
* **Sets**
  * [Cartesian Product](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/cartesian-product) - product of multiple sets
  * [Power Set](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/power-set) - all subsets of the set 
  * [Permutations](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/permutations) (with and without repetitions)
  * [Combinations](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/combinations) (with and without repetitions)
  * [Fisher–Yates Shuffle](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/fisher-yates) - random permutation of a finite sequence
  * [Longest Common Subsequence](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/longest-common-subsequnce) (LCS) 
  * [Longest Increasing subsequence](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/longest-increasing-subsequence)
  * [Shortest Common Supersequence](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/shortest-common-supersequence) (SCS)
  * [Knapsack Problem](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/knapsack-problem) - "0/1" and "Unbound" ones
  * [Maximum Subarray](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/maximum-subarray) - "Brute Force" and "Dynamic Programming" (Kadane's) versions
* **String**
  * [Levenshtein Distance](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/string/levenshtein-distance) - minimum edit distance between two sequences
  * [Hamming Distance](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/string/hamming-distance) - number of positions at which the symbols are different
  * [Knuth–Morris–Pratt Algorithm](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/string/knuth-morris-pratt) - substring search
  * [Rabin Karp Algorithm](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/string/rabin-karp) - substring search
  * [Longest Common Substring](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/string/longest-common-substring)
* **Search**
  * [Binary Search](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/search/binary-search)
* **Sorting**
  * [Bubble Sort](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sorting/bubble-sort)
  * [Selection Sort](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sorting/selection-sort)
  * [Insertion Sort](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sorting/insertion-sort)
  * [Heap Sort](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sorting/heap-sort)
  * [Merge Sort](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sorting/merge-sort)
  * [Quicksort](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sorting/quick-sort)
  * [Shellsort](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sorting/shell-sort)
* **Tree**  
  * [Depth-First Search](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/tree/depth-first-search) (DFS)
  * [Breadth-First Search](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/tree/breadth-first-search) (BFS)
* **Graph**
  * [Depth-First Search](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/depth-first-search) (DFS)
  * [Breadth-First Search](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/breadth-first-search) (BFS)
  * [Dijkstra Algorithm](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/dijkstra) - finding shortest path to all graph vertices
  * [Bellman-Ford Algorithm](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/bellman-ford) - finding shortest path to all graph vertices
  * [Detect Cycle](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/detect-cycle) - for both directed and undirected graphs (DFS and Disjoint Set based versions)
  * [Prim’s Algorithm](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/prim) - finding Minimum Spanning Tree (MST) for weighted undirected graph
  * [Kruskal’s Algorithm](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/kruskal) - finding Minimum Spanning Tree (MST) for weighted undirected graph
  * [Topological Sorting](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/topological-sorting) - DFS method
  * [Articulation Points](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/articulation-points) - Tarjan's algorithm (DFS based)
  * [Bridges](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/bridges) - DFS based algorithm
  * [Eulerian Path and Eulerian Circuit](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/eulerian-path) - Fleury's algorithm - Visit every edge exactly once
  * [Hamiltonian Cycle](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/hamiltonian-cycle) - Visit every vertex exactly once
  * [Strongly Connected Components](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/strongly-connected-components) - Kosaraju's algorithm
  * [Travelling Salesman Problem](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/travelling-salesman) - shortest possible route that visits each city and returns to the origin city
* **Uncategorized**  
  * [Tower of Hanoi](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/uncategorized/hanoi-tower)
  * [N-Queens Problem](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/uncategorized/n-queens)
  * [Knight's Tour](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/uncategorized/knight-tour)
  
### Algorithms by Paradigm

An algorithmic paradigm is a generic method or approach which underlies the design of a class 
of algorithms. It is an abstraction higher than the notion of an algorithm, just as an 
algorithm is an abstraction higher than a computer program.

* **Brute Force** - look at all the possibilities and selects the best solution
  * [Maximum Subarray](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/maximum-subarray)
  * [Travelling Salesman Problem](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/travelling-salesman) - shortest possible route that visits each city and returns to the origin city
* **Greedy** - choose the best option at the current time, without any consideration for the future
  * [Unbound Knapsack Problem](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/knapsack-problem)
  * [Dijkstra Algorithm](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/dijkstra) - finding shortest path to all graph vertices
  * [Prim’s Algorithm](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/prim) - finding Minimum Spanning Tree (MST) for weighted undirected graph
  * [Kruskal’s Algorithm](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/kruskal) - finding Minimum Spanning Tree (MST) for weighted undirected graph
* **Divide and Conquer** - divide the problem into smaller parts and then solve those parts
  * [Binary Search](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/search/binary-search)
  * [Tower of Hanoi](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/uncategorized/hanoi-tower)
  * [Euclidean Algorithm](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/math/euclidean-algorithm) - calculate the Greatest Common Divisor (GCD)
  * [Permutations](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/permutations) (with and without repetitions)
  * [Combinations](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/combinations) (with and without repetitions)
  * [Merge Sort](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sorting/merge-sort)
  * [Quicksort](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sorting/quick-sort)
  * [Tree Depth-First Search](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/tree/depth-first-search) (DFS)
  * [Graph Depth-First Search](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/depth-first-search) (DFS)
* **Dynamic Programming** - build up to a solution using previously found sub-solutions
  * [Fibonacci Number](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/math/fibonacci)
  * [Levenshtein Distance](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/string/levenshtein-distance) - minimum edit distance between two sequences
  * [Longest Common Subsequence](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/longest-common-subsequnce) (LCS)
  * [Longest Common Substring](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/string/longest-common-substring)
  * [Longest Increasing subsequence](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/longest-increasing-subsequence)
  * [Shortest Common Supersequence](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/shortest-common-supersequence)
  * [0/1 Knapsack Problem](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/knapsack-problem)
  * [Integer Partition](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/math/integer-partition)
  * [Maximum Subarray](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/sets/maximum-subarray)
  * [Bellman-Ford Algorithm](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/bellman-ford) - finding shortest path to all graph vertices
* **Backtracking** - similarly to brute force try to generate all possible solutions but each time you generate a solution test 
if it satisfies all conditions, and only then continue generating subsequent solutions. Otherwise backtrack and go on a 
different path of finding solution
  * [Hamiltonian Cycle](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/graph/hamiltonian-cycle) - Visit every vertex exactly once
  * [N-Queens Problem](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/uncategorized/n-queens)
  * [Knight's Tour](https://github.com/mvalenta/csharp-algorithms/tree/master/CSharpAlgorithms.Algorithms/uncategorized/knight-tour)
* **Branch & Bound**

## How to use this repository

**Install all dependencies**
```
npm install
```

**Run all tests**
```
npm test
```

**Run tests by name**
```
npm test -- -t 'LinkedList'
```

**Playground**

You may play with data-structures and algorithms in `./src/playground/playground.js` file and write
tests for it in `./src/playground/__test__/playground.test.js`.

Then just simply run the following command to test if your playground code works as expected:

```
npm test -- -t 'playground'
```

## Useful Information

### References

[▶ Data Structures and Algorithms on YouTube](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)

### Big O Notation
    
Order of growth of algorithms specified in Big O notation.
    
![Big O graphs](https://github.com/trekhleb/javascript-algorithms/blob/master/assets/big-o-graph.png?raw=true)

Source: [Big O Cheat Sheet](http://bigocheatsheet.com/).
    
Below is the list of some of the most used Big O notations and their performance comparisons against different sizes of the input data.

| Big O Notation | Computations for 10 elements | Computations for 100 elements | Computations for 1000 elements  |
| -------------- | ---------------------------- | ----------------------------- | ------------------------------- |
| **O(1)**       | 1                            | 1                             | 1                               |
| **O(log N)**   | 3                            | 6                             | 9                               |
| **O(N)**       | 10                           | 100                           | 1000                            |
| **O(N log N)** | 30                           | 60                            | 9000                            |
| **O(N^2)**     | 100                          | 10000                         | 1000000                         |
| **O(2^N)**     | 1024                         | 1.26e+29                      | 1.07e+301                       |
| **O(N!)**      | 3628800                      | 9.3e+157                      | 4.02e+2567                      |

### Data Structure Operations Complexity
        
| Data Structure          | Access    | Search    | Insertion | Deletion  |
| ----------------------- | :-------: | :-------: | :-------: | :-------: | 
| **Array**               | 1         | n         | n         | n         |
| **Stack**               | n         | n         | 1         | 1         |
| **Queue**               | n         | n         | 1         | 1         | 
| **Linked List**         | n         | n         | 1         | 1         |
| **Hash Table**          | -         | n         | n         | n         |
| **Binary Search Tree**  | n         | n         | n         | n         |
| **B-Tree**              | log(n)    | log(n)    | log(n)    | log(n)    |
| **Red-Black Tree**      | log(n)    | log(n)    | log(n)    | log(n)    |
| **AVL Tree**            | log(n)    | log(n)    | log(n)    | log(n)    |

### Array Sorting Algorithms Complexity

| Name                  | Best      | Average   | Worst         | Memory    | Stable    |
| --------------------- | :-------: | :-------: | :-----------: | :-------: | :-------: |
| **Bubble sort**       | n         | n^2       | n^2           | 1         | Yes       |
| **Insertion sort**    | n         | n^2       | n^2           | 1         | Yes       |
| **Selection sort**    | n^2       | n^2       | n^2           | 1         | No        |
| **Heap sort**         | n log(n)  | n log(n)  | n log(n)      | 1         | No        |
| **Merge sort**        | n log(n)  | n log(n)  | n log(n)      | n         | Yes       |
| **Quick sort**        | n log(n)  | n log(n)  | n^2           | log(n)    | No        |
| **Shell sort**        | n log(n)  | depends on gap sequence   | n (log(n))^2  | 1         | No        |
