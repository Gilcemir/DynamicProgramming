# <center> Time/Space Complexity</center>

## <center> Brute force </center>

    Time O(2^(m+n))
    Space O(n+m) 

    Time: Binary tree of height of n.
    n = m + n; 
                
    Space is the maximum height of the tree, because its the length of the recursive stack in the memory.

## <center> Memoized 1 </center>

    Time O(m*n)
    Space O(n+m) 

    Time: Memoization prevent from recalculating f(m, n), where 0 <= n < n & 0 <= m < m 

    Space: Space is the maximum height of the tree, because its the length of the recursive stack in the memory.