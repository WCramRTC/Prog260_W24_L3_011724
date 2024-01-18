# Programming 260 Notes - Lecture 3 - Recursion and Merge Sort

## Recursion

Recursion is a programming technique where a function calls itself to solve a problem. To implement recursion successfully, you need the following elements:

1. **Base Case**: A base case is a condition that stops the recursion. It's essential to have a base case because without it, the recursion would continue infinitely. When the base case is met, the function should return a value without making any further recursive calls.

2. **Recursive Case**: The recursive case is where the function calls itself with a modified version of the problem. The idea is to break down a larger problem into smaller, similar subproblems. Each time the function is called recursively, it should make progress towards reaching the base case.

3. **Parameters**: The function should have parameters that change with each recursive call. These parameters should be modified in some way to approach the base case. In many cases, you'll pass data or variables that are updated as the recursion progresses.

4. **Function Call**: Inside the function, there should be a call to itself. This is what makes it a recursive function. Be cautious about the conditions under which the recursive call is made to avoid infinite recursion.

5. **Return Statement**: The function should return a value or a result after each call. This result is often combined or processed with results from previous recursive calls to eventually solve the problem.

6. **Control Flow**: Be aware of how the control flows through the recursive calls. Typically, the function should return the result of the recursive call, but sometimes you might need to perform additional operations before or after the recursive call.

Here's a simple example in Python that calculates the factorial of a number using recursion:

```python
def factorial(n):
    # Base case: If n is 0 or 1, return 1
    if n == 0 or n == 1:
        return 1
    # Recursive case: n! = n * (n-1)!
    else:
        return n * factorial(n - 1)
```

In this example, the base case is when `n` is 0 or 1, and the recursive case calculates `n!` by calling the `factorial` function with `n-1`.

Remember that recursion can be a powerful technique but should be used with care, as it can lead to stack overflow errors if not implemented correctly or if the base case is never reached.


```csharp
static void MergeSort(int[] array)
{
    int length = array.Length;

    if (length <= 1)
        return;

    int middleIndex = length / 2;

    int[] leftArray = new int[middleIndex];
    int[] rightArray = new int[length - middleIndex];

    for (int leftIndex = 0; leftIndex < middleIndex; leftIndex++)
    {
        leftArray[leftIndex] = array[leftIndex];
    }
    for (int rightIndex = middleIndex; rightIndex < length; rightIndex++)
    {
        rightArray[rightIndex - middleIndex] = array[rightIndex];
    }

    MergeSort(leftArray);
    MergeSort(rightArray);

    Merge(array, leftArray, rightArray);
}

static void Merge(int[] array, int[] leftArray, int[] rightArray)
{
    int leftLength = leftArray.Length;
    int rightLength = rightArray.Length;
    int arrayIndex = 0, leftIndex = 0, rightIndex = 0;

    while (leftIndex < leftLength && rightIndex < rightLength)
    {
        if (leftArray[leftIndex] <= rightArray[rightIndex])
        {
            array[arrayIndex] = leftArray[leftIndex];
            leftIndex++;
        }
        else
        {
            array[arrayIndex] = rightArray[rightIndex];
            rightIndex++;
        }
        arrayIndex++;
    }

    while (leftIndex < leftLength)
    {
        array[arrayIndex] = leftArray[leftIndex];
        leftIndex++;
        arrayIndex++;
    }

    while (rightIndex < rightLength)
    {
        array[arrayIndex] = rightArray[rightIndex];
        rightIndex++;
        arrayIndex++;
    }
}
```