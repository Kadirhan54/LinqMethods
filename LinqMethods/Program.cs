// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

# region Distinct

// Create a list of integers with some duplicate values
List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5, 6, 6, 7 };

// Use Distinct to get distinct elements from the list
IEnumerable<int> distinctNumbers = numbers.Distinct();

// Print the distinct numbers
Console.WriteLine("Distinct numbers:");
foreach (int number in distinctNumbers)
{
    Console.WriteLine(number);
}

#endregion

#region Skip
// Create a list of integers
List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Use Skip to skip the first 3 elements
IEnumerable<int> skippedNumbers = numbers.Skip(3);

// Print the elements after skipping
Console.WriteLine("Elements after skipping the first 3:");
foreach (int number in skippedNumbers)
{
    Console.WriteLine(number);
}
#endregion

#region Take
// Create a list of integers
List<int> numbers3 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Use Take to take the first 4 elements
IEnumerable<int> takenNumbers = numbers.Take(4);

// Print the elements that were taken
Console.WriteLine("Elements taken from the beginning:");
foreach (int number in takenNumbers)
{
    Console.WriteLine(number);
}
#endregion

#region Concat
// Create two lists of integers
List<int> firstList = new List<int> { 1, 2, 3 };
List<int> secondList = new List<int> { 4, 5, 6 };

// Use Concat to concatenate the two lists
IEnumerable<int> concatenatedList = firstList.Concat(secondList);

// Print the concatenated elements
Console.WriteLine("Concatenated list:");
foreach (int number in concatenatedList)
{
    Console.WriteLine(number);
}
#endregion

#region Contains
// Create a list of strings
List<string> fruits = new List<string> { "apple", "banana", "cherry", "date", "fig" };

// Check if "cherry" exists in the list using Contains
bool containsCherry = fruits.Contains("cherry");

// Check if "grape" exists in the list using Contains
bool containsGrape = fruits.Contains("grape");

// Print the results
Console.WriteLine("Does the list contain 'cherry'? " + containsCherry);
Console.WriteLine("Does the list contain 'grape'? " + containsGrape);
#endregion

#region Reverse
// Create a list of integers
List<int> numbers4 = new List<int> { 1, 2, 3, 4, 5 };

// Use Reverse to reverse the order of elements
numbers4.Reverse();

// Print the reversed elements
Console.WriteLine("Reversed list:");
foreach (int number in numbers4)
{
    Console.WriteLine(number);
}
#endregion

#region Max
// Create a list of integers
List<int> numbers5 = new List<int> { 12, 45, 7, 23, 56, 89, 34, 67 };

// Use Max to find the maximum value
int maxValue = numbers5.Max();

// Print the maximum value
Console.WriteLine("Maximum value in the list: " + maxValue);
#endregion

#region Sum
// Create a list of integers
List<int> numbers6 = new List<int> { 12, 45, 7, 23, 56, 89, 34, 67 };

// Use Sum to calculate the sum of all integers in the list
int sum = numbers6.Sum();

// Print the sum
Console.WriteLine("Sum of all integers in the list: " + sum);
#endregion