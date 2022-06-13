# <center> Dynamic Programming </center>

#### Implementation of some classical problems presented in the freeCodeCamp Video Course [Dynamic Programming](https://www.youtube.com/watch?v=oBt53YbR9Kk)
----

## <center> Fibonacci </center>

### Description:
The Fibonacci sequence is a series of numbers in which each number is the sum of the two that precede it.

The Fibonacci sequence can be described as:
    
    f(n) = f(n - 1) + f(n - 2), n > 2;
    f(0) = 0;
    f(1) = 1;    

## <center> GridTraveler </center>
### Description:
Say that you are a traveler on a 2d grid. You begin in the top-left corner and your gol is to travel to the bottom-right corner. You may only move down or right.

In how many ways can you travel to the goal on a grid with dimensions m * n?

    f(m, n) = f(m - 1, n) + f(m, n - 1),
    f(1, 1) = 1,
    f(x, 0) = 0, 0 <= x <= m,
    f(0, x) = 0, 0 <= x <= n

## <center> CanSum </center>
### Description:
Write a function "CanSum(target, numbers[])" that takes in a target Sum and an array of number of arguments.
The function should return a boolean indicating wheter or not it is possible to generate the target Sum using numbers from the array.
You may use element of the array as many times as needed.
You may assume that all input numbers are non-negative

    bool f(target, nums[])