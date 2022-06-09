# <center> Time/Space Complexity</center>


## <center> Brute force </center>
---

    Time O(2^(m+n))
    Space O(n+m) 

    Time: Binary tree of height of n.
    n = m + n; 
                
    Space is the maximum height of the tree, because its the length of the recursive stack in the memory.

## <center> Memoized 1 </center>
---
    Time O(m*n)
    Space O(n+m) 

    Time: Memoization prevent from recalculating f(m, n), where 0 <= n < n & 0 <= m < m 

    Space: Space is the maximum height of the tree, because its the length of the recursive stack in the memory.

## <center> Combinatorial Solution </center>
---

    Before going deep into the time complexity, lets understand the problem as a combinatorial problem.

    For a grid with m columns and n rows we know that we will move m - 1 times to the right and n -1 times downwards.

>PS.: notice that this problem is slightly diferent from [Lattice paths](https://projecteuler.net/problem=15) because the initial spot is kind of outside the grid, so the number of moves, right and downwards, will be m and n, respectively.

    r = m - 1,
    d = n - 1.

    The number of moves we will take will be r + d;

    imagine a string which represents the path we can possible take.
    
    lenght = r + d.

    for m = 3, n = 2 

    length = 3 - 1 + 2 - 1 = 3;

    r = 2, d = 1;

    Possible ways:

    RRD
    RDR
    DRR

    it leads us to a Binomial coefficient
    (r + d / r) = (r + d / d) = f(m, n);

    Because we have r possible ways of placing R's in the string or d possible ways of placing D's in the string.

    Generic Binomial Coefficient

    Binomial(n, k) = n! / (k! * (n - k)!);

    If we expand n! we have 
        n! = n * (n - 1) * (n - 2) * ... * (n - k + 1) * (n - k)!
        which leads to:

    Binomial(n, k) = (n * (n - 1) * (n - 2) * ... * (n - k + 1) )/ k * (k - 1) * (k - 2) * ... * 1;

    We can reduce to:

    n/1 * (n - 1)/2 * (n - 2)/3 * .. * (n - k + 1)/k

    =>

    Binomial(n, k) =
    answer = 1;
    for i from 1 to k
        answer = answer * (n - k + i)/i
    
    return answer;
    
    