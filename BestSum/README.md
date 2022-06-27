# <center> Time/Space Complexity</center>

    For this analysis we consider:

    m = target sum
    n = length of the array

## <center> Brute force </center>
---

    Time: O(n^m*m)
    Space: O(m^2) 

    Time: n-ary tree of height of m and n as possible number of children.
    **Observation**
    Since here we are using Generic List - not arrays - we simply add the current number to the result, so it has constant cost of time. A little diferent from the given example of the video.
    And for "shortestCombination = remainderCombination;", its simply passing by reference, so its constant time too.


    Space: m (height of the stack)  * m = shortestCombination.Length(worst case). 
    Every recursive stack can have an array of length m in the memory.

## <center> Memoized </center>

    Time: O(m^2*n*)
    Space: O(m^2) 

    Time: m possible keys for the memo * m copies of array "combination" * n length of the array
    
    Space: m keys that can have a list of m length.