# <center> Time/Space Complexity</center>

    For this analysis we consider:

    m = target sum
    n = length of the array

## <center> Brute force </center>
---

    Time: O(n^m)
    Space: O(m) 

    Time: n-ary tree of height of m and n as possible number of children.
                
    Space is the maximum height of the tree, because its the length of the recursive stack in the memory.

## <center> Memoized </center>

    Time: O(m*n)
    Space: O(m) 

    Time: Since its memoized, I will never have to go up in the tree again to recalculate x, where 1 <= x <= m.
    So for each branch in the tree we have n possibilities.

    m possible values for the nodes;
    for each x , where 1 <= x <= m, we have n possibilities.
    
    Space is the maximum height of the tree, because its the length of the recursive stack in the memory.