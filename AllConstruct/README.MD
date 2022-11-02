# <center> Time/Space Complexity</center>

    For this analysis we consider:

    m = length of current string
    n = length of the wordBank array


## <center> Overall </center>

----


For this problem the worse case in all scenarios will be O(m^n) because will always have to return all leaves as result.
Memoized solution can help us along, but wont change it.

For space, it will be O(m), which is the size of the heap. Because it can be very large, we wont include the result.