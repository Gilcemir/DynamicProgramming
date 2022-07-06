# <center> Time/Space Complexity</center>

## <center> Brute force </center>
----

    Time O(2ⁿ)
    Space O(n) 

    Time: Binary tree of height of n. 
                
    Space: Space is the maximum height of the tree, because its the length of the recursive stack in the memory.

## <center> Memoized 1 </center>
----

    Time: O(n)
    Space: O(n)

    Time: Memoization prevent from recalculating f(x), where 0 <= x < n

    Space: for each x, where 0 <= x <= n fib(x) is stored in the memory, which leads to n length

## <center> Memoized 2 </center>
----
    Time: O(n)
    Space: O(1)

    Time: Using previous value which was calculated, from 0 to n

    Space: Does not store unused values, which leads to constant time complexity

## <center> Matrix Solution </center>
----
    Time: O(Log(n))
    Space: O(Log(n))

    Time: Time complexity will be the height of the binary tree generated

    Space: Maximum space in the memory will be the height of the tree
